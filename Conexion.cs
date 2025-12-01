using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFTT_ProyectoParcial3_playlist
{
    public class Conexion
    {
        // Declara el objeto de conexión
        public MySqlConnection conexionBD;

        // CADENA DE CONEXIÓN
        // ¡IMPORTANTE! Reemplaza los placeholders con tus credenciales
        private string servidor = "localhost";
        private string puerto = "3306"; // Revisa que este sea tu puerto
        private string usuario = "root"; // Tu usuario de MySQL
        private string password = "hola"; // ¡Tu contraseña!
        private string baseDeDatos = "playlist"; // Donde se encuentra la tabla 'playcan'

        private string cadenaDeConexion;

        public Conexion()
        {
            // Construye la cadena de conexión
            cadenaDeConexion = string.Format("server={0};port={1};database={2};uid={3};pwd={4}",
                servidor, puerto, baseDeDatos, usuario, password);

            // Inicializa el objeto de conexión
            conexionBD = new MySqlConnection(cadenaDeConexion);
        }

        // Método para abrir la conexión a la base de datos
        public bool abrirBD()
        {
            try
            {
                conexionBD.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Aquí puedes manejar y loguear el error de conexión
                System.Diagnostics.Debug.WriteLine("Error al conectar a la BD: " + ex.Message);
                return false;
            }
        }

        // Método para cerrar la conexión
        public bool cerrarBD()
        {
            try
            {
                conexionBD.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al cerrar la BD: " + ex.Message);
                return false;
            }
        }
    }
}