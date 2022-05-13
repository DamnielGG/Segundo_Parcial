<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar_peliculas.aspx.cs" Inherits="Segundo_Parcial.Agregar_peliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Agregue las peliculas</p>
    <p>
        &nbsp;</p>
    <p>
        Titulo:</p>
    <p>
        <asp:TextBox ID="TextBoxTituloAgregar" runat="server"></asp:TextBox>
    </p>
    <p>
        Año:</p>
    <p>
        <asp:TextBox ID="TextBoxAñoAgregar" runat="server"></asp:TextBox>
    </p>
    <p>
        Genero:</p>
    <p>
        <asp:TextBox ID="TextBoxGeneroAgregar" runat="server"></asp:TextBox>
    </p>
    <p>
        Estudio:</p>
    <p>
        <asp:TextBox ID="TextBoxEstudioAgregar" runat="server"></asp:TextBox>
    </p>
    <p>
        Elenco:</p>
    <p>
        <asp:TextBox ID="TextBoxElencoAgregar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonGuardarPeli" runat="server" OnClick="Button1_Click" Text="Guardar Datos" />
    </p>
</asp:Content>
