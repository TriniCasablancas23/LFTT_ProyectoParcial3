<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Playcan.aspx.cs" Inherits="LFTT_ProyectoParcial3_playlist.Playcan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Playlist Personal</h3>

<asp:TextBox ID="txtNombreCancion" runat="server" placeholder="Nombre de la Canción"></asp:TextBox><br />
<asp:TextBox ID="txtDuracion" runat="server" placeholder="Duración (ej. 03:30)"></asp:TextBox><br />
<asp:TextBox ID="txtAlbum" runat="server" placeholder="Álbum"></asp:TextBox><br />
<asp:TextBox ID="txtArtista" runat="server" placeholder="Artista"></asp:TextBox><br />
<asp:TextBox ID="txtAnio" runat="server" placeholder="Año"></asp:TextBox><br />
<asp:TextBox ID="txtGenero" runat="server" placeholder="Género"></asp:TextBox><br /><br />

<asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
&nbsp;&nbsp;&nbsp;

<asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
<br /><br />

<asp:GridView ID="gridPlaylist" runat="server" 
    AutoGenerateColumns="False" 
    DataKeyNames="id" 
    OnSelectedIndexChanged="gridPlaylist_SelectedIndexChanged" 
    OnRowDeleting="gridPlaylist_RowDeleting">
    <Columns>
        <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" />
        <asp:CommandField ShowDeleteButton="True" DeleteText="Eliminar" />
        
        <asp:BoundField DataField="nombre_cancion" HeaderText="Canción" />
        <asp:BoundField DataField="Duracion" HeaderText="Duración" />
        <asp:BoundField DataField="Album" HeaderText="Álbum" />
        <asp:BoundField DataField="Artista" HeaderText="Artista" />
        <asp:BoundField DataField="Anio" HeaderText="Año" />
        <asp:BoundField DataField="Genero" HeaderText="Género" />
    </Columns>
</asp:GridView>
</asp:Content>
