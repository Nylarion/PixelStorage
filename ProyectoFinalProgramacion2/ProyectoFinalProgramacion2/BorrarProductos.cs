using Microsoft.Data.SqlClient;
using ProyectoFinalProgramacion2.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion2
{
    public partial class BorrarProductos : Form
    {
        public BorrarProductos()
        {
            InitializeComponent();
            CargarInventario();
        }

        private void CargarInventario()
        {
            // La propiedad DataSource enlaza el DataGridView con una fuente de datos
            // Llamamos al stored procedure "SP_LISTAR_EMPLEADO" que devuelve todos los empleados
            // La clase Conexion.EjecutarConsulta:
            // 1. Se conecta a la base de datos
            // 2. Ejecuta el stored procedure
            // 3. Devuelve un DataTable con los resultados
            // 4. Ese DataTable se asigna al DataGridView y se muestra automáticamente
            dgvBorrarProducto.DataSource = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
        }

        // ===============================================
        // EVENTO: BOTÓN ELIMINAR - Eliminar un empleado
        // ===============================================

        // Se ejecuta cuando el usuario hace clic en el botón "Eliminar"
        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            // ===============================================
            // PASO 1: VALIDAR QUE HAYA UNA FILA SELECCIONADA
            // ===============================================

            // CurrentRow representa la fila que el usuario tiene seleccionada
            // Si es null, significa que no hay ninguna fila seleccionada
            if (dgvBorrarProducto.CurrentRow == null || dgvBorrarProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Salir del método si no hay selección
            }

            // ===============================================
            // PASO 2: OBTENER EL ID DEL EMPLEADO SELECCIONADO
            // ===============================================

            // Obtener el valor de la celda "ID" de la fila seleccionada
            // dgvEmpleados.CurrentRow: la fila seleccionada
            // .Cells["ID"]: la celda de la columna "ID"
            // .Value: el valor dentro de esa celda
            // Convert.ToInt32: convertir ese valor a un número entero
            int id = Convert.ToInt32(dgvBorrarProducto.CurrentRow.Cells["ID"].Value);

            // ===============================================
            // PASO 3: CREAR EL PARÁMETRO PARA EL STORED PROCEDURE
            // ===============================================

            // El stored procedure de eliminación solo necesita el ID del empleado
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@P_ID", id)
            };

            // ===============================================
            // PASO 4: EJECUTAR EL STORED PROCEDURE DE ELIMINACIÓN
            // ===============================================

            // Ejecutar el stored procedure "SP_ELIMINAR_EMPLEADO"
            // Este hace un DELETE en la base de datos del empleado con ese ID
            Conexion.EjecutarComando("SP_ELIMINAR_PRODUCTO", parametros);

            // ===============================================
            // PASO 5: ACTUALIZAR LA LISTA
            // ===============================================

            // Recargar la lista para que el empleado eliminado ya no aparezca
            CargarInventario();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string fitro = txtFiltroBuscar.Text;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@P_FILTRO", fitro)
            };

            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_LISTAR_PRODUCTO_FILTRO", parametros);
            dgvBorrarProducto.DataSource = empleadosFiltrados;
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroBuscar.Clear();
            txtIDProtuctoBorrar.Clear();
            txtMarcaProducto.Clear();
            txtModeloProducto.Clear();
            txtCategoriaProducto.Clear();
            txtPrecioProducto.Clear();

            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
            dgvBorrarProducto.DataSource = empleadosFiltrados;
        }

        private void dgvBorrarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDProtuctoBorrar.Text = dgvBorrarProducto.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtMarcaProducto.Text = dgvBorrarProducto.Rows[e.RowIndex].Cells["MARCA"].Value.ToString();
            txtModeloProducto.Text = dgvBorrarProducto.Rows[e.RowIndex].Cells["MODELO"].Value.ToString();
            txtCategoriaProducto.Text = dgvBorrarProducto.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
            txtPrecioProducto.Text = dgvBorrarProducto.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString();
        }
    }
}
