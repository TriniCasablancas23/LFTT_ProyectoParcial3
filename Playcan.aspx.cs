using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo; // ¡IMPORTANTE! Se necesita para acceder a tu clase Playcan

namespace LFTT_ProyectoParcial3_playlist
{
    // Asegúrate de que este nombre (WebForm1) coincida con tu archivo .aspx
    public partial class Playcan : System.Web.UI.Page
    {
        // 1. Declarar la instancia de la clase de modelo
        Modelo.Playcan playcan;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicializa la clase y carga la tabla al cargar la página
                playcan = new Modelo.Playcan();
                playcan.gridPlaycan(gridPlaylist);
            }
        }

        // ----------------------------------------------------
        // C: CREAR / ALTA
        // ----------------------------------------------------
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            playcan = new Modelo.Playcan();

            // Llama al método de la clase Playcan.cs (similar a la práctica [cite: 59-61])
            int ejecuta = playcan.agregarCancion(
                txtNombreCancion.Text,
                txtDuracion.Text,
                txtAlbum.Text,
                txtArtista.Text,
                txtAnio.Text,
                txtGenero.Text
            );

            if (ejecuta > 0)
            {
                playcan.gridPlaycan(gridPlaylist); // Recarga el GridView
                lblMensaje.Text = "Canción Agregada";
            }
            else
            {
                lblMensaje.Text = "Canción No Agregada";
            }
        }

        // ----------------------------------------------------
        // U: CARGAR DATOS PARA ACTUALIZAR
        // ----------------------------------------------------
        protected void gridPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asigna los valores de la fila seleccionada a los TextBoxes (similar a la práctica [cite: 161-163])
            // Índices de celdas: 2: nombre_cancion, 3: Duracion, 4: Album, 5: Artista, 6: Anio, 7: Genero
            txtNombreCancion.Text = gridPlaylist.SelectedRow.Cells[2].Text;
            txtDuracion.Text = gridPlaylist.SelectedRow.Cells[3].Text;
            txtAlbum.Text = gridPlaylist.SelectedRow.Cells[4].Text;
            txtArtista.Text = gridPlaylist.SelectedRow.Cells[5].Text;
            txtAnio.Text = gridPlaylist.SelectedRow.Cells[6].Text;
            txtGenero.Text = gridPlaylist.SelectedRow.Cells[7].Text;
        }

        // ----------------------------------------------------
        // U: ACTUALIZAR / MODIFICAR
        // ----------------------------------------------------
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            playcan = new Modelo.Playcan();

            int idSeleccionado = Convert.ToInt32(gridPlaylist.SelectedValue);

            // Llama al método de actualización (similar a la práctica [cite: 166-167])
            int ejecuta = playcan.actualizarCancion(
                idSeleccionado,
                txtNombreCancion.Text,
                txtDuracion.Text,
                txtAlbum.Text,
                txtArtista.Text,
                txtAnio.Text,
                txtGenero.Text
            );

            if (ejecuta > 0)
            {
                playcan.gridPlaycan(gridPlaylist);
                lblMensaje.Text = "Canción Modificada";
            }
            else
            {
                lblMensaje.Text = "Canción No Modificada";
            }
        }

        // ----------------------------------------------------
        // D: ELIMINAR / BAJA
        // ----------------------------------------------------
        protected void gridPlaylist_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            playcan = new Modelo.Playcan();

            // Obtiene el ID a eliminar de la clave de la fila (similar a la práctica [cite: 251-252])
            int ejecuta = playcan.eliminarCancion(Convert.ToInt32(e.Keys["id"]));

            if (ejecuta > 0)
            {
                playcan.gridPlaycan(gridPlaylist);
                lblMensaje.Text = "Canción Eliminada";
            }
            else
            {
                lblMensaje.Text = "Canción No Eliminada";
            }
        }
    }
}