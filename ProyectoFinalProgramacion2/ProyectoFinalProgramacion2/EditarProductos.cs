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
    public partial class EditarProductos : Form
    {
        public EditarProductos()
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
            dgvEditarProducto.DataSource = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
        }

        private void dgvEditarProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIDProducto.Text = dgvEditarProducto.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtMarcaProducto.Text = dgvEditarProducto.Rows[e.RowIndex].Cells["MARCA"].Value.ToString();
                txtModeloProducto.Text = dgvEditarProducto.Rows[e.RowIndex].Cells["MODELO"].Value.ToString();
                txtCategoriaProducto.Text = dgvEditarProducto.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
                txtPrecioProducto.Text = dgvEditarProducto.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString();
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvEditarProducto.CurrentRow == null || dgvEditarProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (string.IsNullOrWhiteSpace(txtIDProducto.Text) ||
                     string.IsNullOrWhiteSpace(txtMarcaProducto.Text) ||
                     string.IsNullOrWhiteSpace(txtModeloProducto.Text) ||
                     string.IsNullOrWhiteSpace(txtCategoriaProducto.Text) ||
                     string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int id = Convert.ToInt32(txtIDProducto.Text);
                string marca = txtMarcaProducto.Text;
                string modelo = txtModeloProducto.Text;
                string categoria = txtCategoriaProducto.Text;
                int precio = Convert.ToInt32(txtPrecioProducto.Text);

                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@P_ID", id),
                new SqlParameter("@P_MARCA", marca),
                new SqlParameter("@P_MODELO", modelo),
                new SqlParameter("@P_CATEGORIA", categoria),
                new SqlParameter("@P_PRECIO", precio)
                };



                Conexion.EjecutarComando("SP_ACTUALIZAR_PRODUCTO", parametros);
                MessageBox.Show("Producto actualizado correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string fitro = txtFiltroBuscar.Text;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@P_FILTRO", fitro)
            };

            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_LISTAR_PRODUCTO_FILTRO", parametros);
            dgvEditarProducto.DataSource = empleadosFiltrados;
        }

        private void btnLimpiarFiltroCampo_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroBuscar.Clear();
            txtIDProducto.Clear();
            txtMarcaProducto.Clear();
            txtModeloProducto.Clear();
            txtCategoriaProducto.Clear();
            txtPrecioProducto.Clear();
            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
            dgvEditarProducto.DataSource = empleadosFiltrados;
        }
    }
}
