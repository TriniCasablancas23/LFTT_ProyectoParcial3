using LFTT_ProyectoParcial3_playlist;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Modelo // Asegúrate que el namespace sea correcto (ej: TuProyecto.Modelo o solo Modelo)
{
    public class Playcan
    {
        Conexion con; // Clase que acabas de crear

        // ----------------------------------------------------
        // R: LECTURA/CONSULTA
        // ----------------------------------------------------
        private DataTable TablaPlaycan()
        {
            DataTable playcan = new DataTable();
            con = new Conexion();
            con.abrirBD();
            // Consulta para obtener todos los campos de tu tabla
            string sql = "SELECT id, nombre_cancion, Duracion, Album, Artista, Anio, Genero FROM playcan";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, con.conexionBD);
            query.Fill(playcan);
            con.cerrarBD();
            return playcan;
        }

        public void gridPlaycan(GridView grid)
        {
            grid.DataSource = TablaPlaycan();
            grid.DataBind();
        }

        // ----------------------------------------------------
        // C: CREAR / ALTA
        // ----------------------------------------------------
        public int agregarCancion(string nombreCancion, string duracion, string album, string artista, string anio, string genero)
        {
            int bandera = 0;
            con = new Conexion();
            con.abrirBD();

            // Sentencia INSERT con tus 6 campos
            string sql = string.Format("INSERT INTO playcan (nombre_cancion, Duracion, Album, Artista, Anio, Genero) VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",
                nombreCancion, duracion, album, artista, anio, genero);

            MySqlCommand comando = new MySqlCommand(sql, con.conexionBD);
            comando.Connection = con.conexionBD;
            bandera = comando.ExecuteNonQuery();
            con.cerrarBD();
            return bandera;
        }

        // ----------------------------------------------------
        // U: ACTUALIZAR / MODIFICAR
        // ----------------------------------------------------
        public int actualizarCancion(int id, string nombreCancion, string duracion, string album, string artista, string anio, string genero)
        {
            int bandera = 0;
            con = new Conexion();
            con.abrirBD();

            // Sentencia UPDATE con tus 6 campos y el ID
            string sql = string.Format("UPDATE playcan SET nombre_cancion='{0}', Duracion='{1}', Album='{2}', Artista='{3}', Anio='{4}', Genero='{5}' WHERE id={6};",
                nombreCancion, duracion, album, artista, anio, genero, id);

            MySqlCommand comando = new MySqlCommand(sql, con.conexionBD);
            comando.Connection = con.conexionBD;
            bandera = comando.ExecuteNonQuery();
            con.cerrarBD();
            return bandera;
        }

        // ----------------------------------------------------
        // D: ELIMINAR / BAJA
        // ----------------------------------------------------
        public int eliminarCancion(int id)
        {
            int bandera = 0;
            con = new Conexion();
            con.abrirBD();

            // Sentencia DELETE
            string sql = string.Format("DELETE FROM playcan WHERE id={0};", id);

            MySqlCommand comando = new MySqlCommand(sql, con.conexionBD);
            comando.Connection = con.conexionBD;
            bandera = comando.ExecuteNonQuery();
            con.cerrarBD();
            return bandera;
        }
    }
}