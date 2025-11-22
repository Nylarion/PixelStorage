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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {

            // ===============================================
            // PASO 1: VALIDAR QUE LOS CAMPOS NO ESTÉN VACÍOS
            // ===============================================

            // Validar que el campo de usuario no esté vacío o solo tenga espacios
            // string.IsNullOrWhiteSpace verifica si el texto es null, vacío o solo espacios
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                // Mostrar un mensaje de advertencia al usuario
                MessageBox.Show("Por favor ingrese un usuario", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Colocar el cursor en el campo de usuario para que pueda escribir
                txtUsuario.Focus();

                // Salir del método (no continuar con el login)
                return;
            }

            // Validar que el campo de contraseña no esté vacío
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            // ===============================================
            // PASO 2: PREPARAR LA CONEXIÓN A LA BASE DE DATOS
            // ===============================================

            // Declarar la variable de conexión e inicializarla en null
            // La inicializamos en null para poder verificarla en el bloque "finally"
            SqlConnection conexion = null;

            // El bloque try-catch-finally maneja los errores que puedan ocurrir
            try
            {
                // ===============================================
                // PASO 3: CREAR LA CONEXIÓN Y EL COMANDO
                // ===============================================

                // Obtener una conexión a la base de datos usando nuestra clase Conexion
                conexion = Conexion.ObtenerConexion();

                // Crear un comando para ejecutar el stored procedure "SP_VALIDA_LOGIN"
                // Un stored procedure es como una "función" guardada en SQL Server
                // que contiene la lógica para validar usuario y contraseña
                SqlCommand comando = new SqlCommand("SP_VALIDAR_LOGIN", conexion);

                // Indicar que vamos a ejecutar un stored procedure (no una consulta SQL normal)
                comando.CommandType = CommandType.StoredProcedure;

                // ===============================================
                // PASO 4: AGREGAR PARÁMETROS AL COMANDO
                // ===============================================

                // Los parámetros son los valores que le pasamos al stored procedure
                // El símbolo @ indica que es un parámetro en SQL Server
                // El stored procedure espera recibir @P_USU_NOMBRE y @P_PASS
                comando.Parameters.AddWithValue("@P_USU_NOMBRE", txtUsuario.Text);
                comando.Parameters.AddWithValue("@P_CONTRASENA", txtContrasena.Text);
                // ===============================================
                // PASO 5: EJECUTAR EL COMANDO
                // ===============================================

                // Abrir la conexión a la base de datos
                // Hasta este momento, la conexión estaba creada pero no abierta
                conexion.Open();

                // Ejecutar el comando y obtener el resultado
                // ExecuteScalar() se usa cuando el stored procedure devuelve UN SOLO VALOR
                // En este caso, devuelve la cantidad de usuarios que coinciden (0 o 1)
                // Convert.ToInt32 convierte el resultado a un número entero
                int count = Convert.ToInt32(comando.ExecuteScalar());

                // ===============================================
                // PASO 6: VERIFICAR EL RESULTADO
                // ===============================================

                // Si count es mayor que 0, significa que encontró el usuario
                if (count > 0)
                {
                    // Login exitoso - Usuario y contraseña correctos
                    MessageBox.Show("Sesión iniciada correctamente.", "Bienvenido a PixelStorage",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    // Login fallido - Usuario o contraseña incorrectos
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Limpiar el campo de contraseña por seguridad
                    // No queremos que la contraseña incorrecta quede visible
                    txtContrasena.Clear();

                    // Regresar el cursor al campo de usuario
                    txtUsuario.Focus();
                }
            }
            // ===============================================
            // PASO 7: MANEJO DE ERRORES
            // ===============================================

            catch (SqlException ex)
            {
                // Este bloque captura errores específicos de SQL Server
                // Por ejemplo:
                // - El servidor SQL no está disponible
                // - La base de datos no existe
                // - El stored procedure no existe
                // - Error en la cadena de conexión
                MessageBox.Show("Error de base de datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Este bloque captura cualquier otro tipo de error inesperado
                // que no sea específico de SQL Server
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // ===============================================
                // PASO 8: CERRAR LA CONEXIÓN (MUY IMPORTANTE)
                // ===============================================

                // El bloque "finally" SIEMPRE se ejecuta,
                // haya ocurrido un error o no

                // Verificar que la conexión no sea null Y que esté abierta
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    // Cerrar la conexión para liberar recursos
                    // Es MUY IMPORTANTE cerrar las conexiones cuando no las usamos
                    // para no desperdiciar memoria y permitir que otros procesos las usen
                    conexion.Close();
                }
            }
        }
    }
}
