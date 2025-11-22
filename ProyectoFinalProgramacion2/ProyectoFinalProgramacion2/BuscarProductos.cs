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
    public partial class BuscarProductos : Form
    {
        public BuscarProductos()
        {
            InitializeComponent();
            CargarInventario();
        }

        // Constructor del formulario
        // Se ejecuta automáticamente cuando se crea el formulario
        // ===============================================
        // MÉTODO: CARGAR EMPLEADOS EN EL DATAGRIDVIEW
        // ===============================================

        // Este método consulta la base de datos y muestra
        // todos los empleados en la tabla (DataGridView)
        private void CargarInventario()
        {
            // La propiedad DataSource enlaza el DataGridView con una fuente de datos
            // Llamamos al stored procedure "SP_LISTAR_EMPLEADO" que devuelve todos los empleados
            // La clase Conexion.EjecutarConsulta:
            // 1. Se conecta a la base de datos
            // 2. Ejecuta el stored procedure
            // 3. Devuelve un DataTable con los resultados
            // 4. Ese DataTable se asigna al DataGridView y se muestra automáticamente
            dgvBuscarProducto.DataSource = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string fitro = txtFiltroBuscar.Text;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@P_FILTRO", fitro)
            };

            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_LISTAR_PRODUCTO_FILTRO", parametros);
            dgvBuscarProducto.DataSource = empleadosFiltrados;
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroBuscar.Clear();
            DataTable empleadosFiltrados = Conexion.EjecutarConsulta("SP_SELECCIONAR_PRODUCTO", null);
            dgvBuscarProducto.DataSource = empleadosFiltrados;
        }
    }
}
