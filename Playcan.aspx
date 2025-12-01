<%@ Page Title="Playlist inzana" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Playcan.aspx.cs" Inherits="LFTT_ProyectoParcial3_playlist.Playcan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h3>Playlist Personal</h3>
<link rel="stylesheet" href="Styles/RetroStyles.css" />
<link rel="icon" href="<%= ResolveUrl("~/images/disco.ico") %>" type="image/x-icon" />
<asp:TextBox ID="txtNombreCancion" runat="server" CssClass="form-control-retro" placeholder="Nombre de la Canción"></asp:TextBox><br />
<asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control-retro" placeholder="Duración (ej. 03:30)"></asp:TextBox><br />
<asp:TextBox ID="txtAlbum" runat="server" CssClass="form-control-retro" placeholder="Álbum"></asp:TextBox><br />
<asp:TextBox ID="txtArtista" runat="server" CssClass="form-control-retro" placeholder="Artista"></asp:TextBox><br />
<asp:TextBox ID="txtAnio" runat="server" CssClass="form-control-retro" placeholder="Año"></asp:TextBox><br />
<asp:TextBox ID="txtGenero" runat="server" CssClass="form-control-retro" placeholder="Género"></asp:TextBox><br /><br />

<asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn-retro" OnClick="btnAgregar_Click" />
<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn-retro" OnClick="btnActualizar_Click" />
&nbsp;&nbsp;&nbsp;

<asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="#00FF00"></asp:Label>
<br /><br />

<asp:GridView ID="gridPlaylist" runat="server" 
    CssClass="table-retro"
    AutoGenerateColumns="False" 
    DataKeyNames="id" 
    OnSelectedIndexChanged="gridPlaylist_SelectedIndexChanged" 
    OnRowDeleting="gridPlaylist_RowDeleting">
    <Columns>
        <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" ItemStyle-CssClass="btn-retro" ControlStyle-CssClass="btn-retro"/>
        <asp:CommandField ShowDeleteButton="True" DeleteText="Eliminar" ItemStyle-CssClass="btn-retro" ControlStyle-CssClass="btn-retro"/>
        
        <asp:BoundField DataField="nombre_cancion" HeaderText="Canción" />
        <asp:BoundField DataField="Duracion" HeaderText="Duración" />
        <asp:BoundField DataField="Album" HeaderText="Álbum" />
        <asp:BoundField DataField="Artista" HeaderText="Artista" />
        <asp:BoundField DataField="Anio" HeaderText="Año" />
        <asp:BoundField DataField="Genero" HeaderText="Género" />
    </Columns>
</asp:GridView>
</asp:Content>
