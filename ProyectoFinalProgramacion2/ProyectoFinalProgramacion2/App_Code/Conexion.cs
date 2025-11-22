using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion2.App_Code
{
    // Esta clase maneja TODA la comunicación con la base de datos
    // Es como un "puente" entre nuestra aplicación de Windows Forms y SQL Server
    public class Conexion
    {

        // CADENA DE CONEXIÓN: Es como la "dirección" de nuestra base de datos
        // Contiene la información necesaria para conectarse:
        // - Server: El nombre del servidor SQL (en este caso es local con SQL Express)
        // - Database: El nombre de la base de datos que queremos usar
        // - Trusted_Connection=True: Usa la autenticación de Windows (no necesita usuario/contraseña)
        // - TrustServerCertificate=True: Confía en el certificado del servidor (necesario para conexiones locales)
        private static string cadena = "Server=PC\\SQLEXPRESS;Database=BD_INVENTARIO;Trusted_Connection=True;TrustServerCertificate=True;";

        // MÉTODO 1: Crear y devolver una conexión a SQL Server
        // Este método crea un objeto SqlConnection que representa la conexión física a la base de datos
        // IMPORTANTE: Este método NO abre la conexión, solo la crea
        public static SqlConnection ObtenerConexion()
        {
            // Crear un nuevo objeto de conexión usando nuestra cadena de conexión
            SqlConnection conexion = new SqlConnection(cadena);

            // Devolver la conexión (todavía está cerrada en este punto)
            return conexion;
        }

        // MÉTODO 2: Ejecutar una consulta SELECT y devolver los datos en una tabla
        // Este método es ideal para LEER datos (por ejemplo: listar empleados)
        // Parámetro: El nombre del stored procedure que queremos ejecutar
        // Retorna: Un DataTable con todos los registros que devuelve el procedimiento
        public static DataTable EjecutarConsulta(string procedimiento, SqlParameter[] parametros)
        {
            // Paso 1: Obtener una conexión a la base de datos
            using (SqlConnection conexion = ObtenerConexion())
            {

                // Paso 2: Crear un comando SQL
                // Un SqlCommand es como una "orden" que le damos a SQL Server
                // Le pasamos el nombre del procedimiento y la conexión que usaremos
                SqlCommand comando = new SqlCommand(procedimiento, conexion);

                // Paso 3: Indicar que vamos a ejecutar un stored procedure (no una consulta SQL directa)
                comando.CommandType = CommandType.StoredProcedure;

                // Paso 4: Crear un adaptador de datos
                // El SqlDataAdapter actúa como un "intermediario" que:
                // - Abre la conexión automáticamente
                // - Ejecuta el comando
                // - Llena un DataTable con los resultados
                // - Cierra la conexión automáticamente

                if (parametros != null)
                {
                    // Agregar los parámetros al comando (si existen)
                    comando.Parameters.AddRange(parametros);
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Paso 5: Crear una tabla en memoria para almacenar los datos
                DataTable tabla = new DataTable();

                // Paso 6: Llenar la tabla con los datos que devuelve el procedimiento
                // El método Fill hace todo el trabajo: abre conexión, ejecuta, llena, cierra
                adaptador.Fill(tabla);

                // Paso 7: Devolver la tabla con los datos
                return tabla;

            }

        }

        // MÉTODO 3: Ejecutar comandos que NO devuelven datos (INSERT, UPDATE, DELETE)
        // Este método es ideal para MODIFICAR datos (agregar, actualizar, eliminar empleados)
        // Parámetros:
        // - procedimiento: El nombre del stored procedure a ejecutar
        // - parametros: Un arreglo con los valores que necesita el procedimiento
        public static void EjecutarComando(string procedimiento, SqlParameter[] parametros)
        {
            // La palabra "using" es MUY IMPORTANTE
            // Garantiza que la conexión se cierre automáticamente al terminar,
            // incluso si ocurre un error. Es una buena práctica de programación.
            using (SqlConnection conexion = ObtenerConexion())
            {
                // Paso 1: Crear el comando SQL con el nombre del procedimiento y la conexión
                SqlCommand comando = new SqlCommand(procedimiento, conexion);

                // Paso 2: Indicar que es un stored procedure
                comando.CommandType = CommandType.StoredProcedure;

                // Paso 3: Agregar los parámetros al comando (si existen)
                // Los parámetros son los valores que el stored procedure necesita
                // Por ejemplo: el nombre, cargo y sueldo de un empleado
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                // Paso 4: Intentar ejecutar el comando (con manejo de errores)
                try
                {
                    // Abrir la conexión manualmente (a diferencia del adaptador)
                    conexion.Open();

                    // ExecuteNonQuery ejecuta el comando y devuelve el número de filas afectadas
                    // Se usa para INSERT, UPDATE, DELETE (comandos que NO devuelven datos)
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Nota: No mostramos mensajes aquí, eso lo hace el formulario
                    // Este método solo se encarga de ejecutar el comando
                }
                catch (SqlException ex)
                {
                    // Si ocurre un error de SQL Server (tabla no existe, parámetro incorrecto, etc.)
                    // lanzamos una excepción con un mensaje más claro
                    throw new Exception("Error al ejecutar el comando " + procedimiento + ": " + ex.Message);
                }
                // La conexión se cierra automáticamente gracias al "using"
            }
        }

    }
}
