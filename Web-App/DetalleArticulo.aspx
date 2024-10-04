<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Detalle del Artículo</h2>

    <div>
        <strong>Código:</strong> <asp:Label ID="lblCodigo" runat="server"></asp:Label><br />
        <strong>Nombre:</strong> <asp:Label ID="lblNombre" runat="server"></asp:Label><br />
        <strong>Descripción:</strong> <asp:Label ID="lblDescripcion" runat="server"></asp:Label><br />
        <strong>Marca:</strong> <asp:Label ID="lblMarca" runat="server"></asp:Label><br />
        <strong>Categoría:</strong> <asp:Label ID="lblCategoria" runat="server"></asp:Label><br />
        <strong>Precio:</strong> <asp:Label ID="lblPrecio" runat="server"></asp:Label><br />
        <strong>Imagen:</strong> <asp:Image ID="imgArticulo" runat="server" Width="200px" Height="200px" />
    </div>
</asp:Content>
