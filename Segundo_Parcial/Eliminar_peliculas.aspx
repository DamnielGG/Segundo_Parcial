<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar_peliculas.aspx.cs" Inherits="Segundo_Parcial.Eliminar_peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Ingrese solamente el titulo de la pelicula que desea eliminar</p>
    <p>
        &nbsp;</p>
    <p>
        Titulo:</p>
    <p>
        <asp:TextBox ID="TextBoxTituloPeliEliminar" runat="server"></asp:TextBox>
    </p>
    <p>
        Año:
    </p>
    <p>
        <asp:TextBox ID="TextBoxAñoEliminar" runat="server"></asp:TextBox>
    </p>
    <p>
        Estudio:</p>
    <p>
        <asp:TextBox ID="TextBoxEstudioEliminar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarPeli" runat="server" Height="26px" OnClick="Button1_Click" Text="Buscar película" />
    </p>
    <p>
        <asp:Button ID="ButtonEliminarPelicula" runat="server" OnClick="ButtonEliminarPelicula_Click" Text="Eliminar película" />
    </p>
</asp:Content>
