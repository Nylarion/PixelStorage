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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }
        // ===============================================
        // EVENTO: BOTÓN AGREGAR - Agregar un nuevo empleado
        // ===============================================

        // Se ejecuta cuando el usuario hace clic en el botón "Agregar"
        private void btnLimpiarIngresados_Click(object sender, EventArgs e)
        {
            txtMarcaIngresar.Clear();
            txtModeloIngresar.Clear();
            txtCategoriaIngresar.Clear();
            txtPrecioIngresar.Clear();

        }

        private void btnAgregarIngresados_Click(object sender, EventArgs e)
        {
            // ===============================================
            // PASO 1: VALIDAR QUE TODOS LOS CAMPOS TENGAN DATOS
            // ===============================================

            // Verificar que el usuario haya llenado todos los campos
            // Si algún campo está vacío (""), mostrar un mensaje y salir
            if (txtMarcaIngresar.Text == "" || txtModeloIngresar.Text == "" || txtCategoriaIngresar.Text == "" || txtPrecioIngresar.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos antes de ingresar un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Salir del método sin agregar nada
            }

            // ===============================================
            // PASO 2: VALIDAR QUE EL SUELDO SEA UN NÚMERO
            // ===============================================

            // Declarar una variable para almacenar el sueldo convertido
            int precio;

            // TryParse intenta convertir el texto a un número entero
            // Si la conversión es exitosa: devuelve true y guarda el número en "sueldo"
            // Si la conversión falla: devuelve false (por ejemplo, si escribieron "abc")
            if (!int.TryParse(txtPrecioIngresar.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Salir del método si el sueldo no es válido
            }

            // ===============================================
            // PASO 3: CREAR LOS PARÁMETROS PARA EL STORED PROCEDURE
            // ===============================================

            // Un stored procedure es como una función en SQL Server
            // que necesita recibir valores (parámetros)

            // Crear un arreglo de SqlParameter con los 3 valores que necesita el SP
            SqlParameter[] parametros = new SqlParameter[]
            {
                // Parámetro 1: La marca del producto
                // @P_MARCA es el nombre que espera el stored procedure
                // txtMarcaIngresar.Text es el valor que escribió el usuario
                new SqlParameter("@P_MARCA", txtMarcaIngresar.Text),
                
                // Parámetro 2: El modelo del producto
                new SqlParameter("@P_MODELO", txtModeloIngresar.Text),

                //Parámetro 3: La categoría del producto
                new SqlParameter("P_CATEGORIA", txtCategoriaIngresar.Text),
                
                // Parámetro 3: El precio del producto (ya validado como número)
                new SqlParameter("@P_PRECIO", precio)
            };

            // ===============================================
            // PASO 4: EJECUTAR EL STORED PROCEDURE
            // ===============================================

            // Llamar al método EjecutarComando de nuestra clase Conexion
            // Este método:
            // 1. Se conecta a la base de datos
            // 2. Ejecuta el stored procedure "SP_AGREGAR_EMPLEADO"
            // 3. Le pasa los parámetros que creamos
            // 4. El stored procedure hace el INSERT en la tabla
            Conexion.EjecutarComando("SP_AGREGAR_PRODUCTO", parametros);

            // ===============================================
            // PASO 5: ACTUALIZAR LA LISTA Y LIMPIAR CAMPOS
            // ===============================================

            // Recargar la lista de empleados para mostrar el nuevo empleado
            // Limpiar los campos de texto para que el usuario pueda agregar otro empleado

            txtMarcaIngresado.Text = txtMarcaIngresar.Text;
            txtModeloIngresado.Text = txtModeloIngresar.Text;
            txtCategoriaIngresado.Text = txtCategoriaIngresar.Text;
            txtPrecioIngresado.Text = txtPrecioIngresar.Text;
        }
    }
}
