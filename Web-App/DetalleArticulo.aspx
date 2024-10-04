<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <h2 class="text-center">Detalle del Artículo</h2>
    <hr />
    <div class="d-flex align-items-center">
    
    <div>
        <asp:Image ID="imgArticulo" runat="server" CssClass="rounded img-fluid" Style="max-width: 300px; height: auto; object-fit: cover;" />
    </div>
    <div class="ml-4 d-flex flex-column justify-content-center">
        <div class="bg-primary bg-gradient text-white p-3 rounded">
            <strong>Código:</strong> <asp:Label ID="lblCodigo" CssClass="text-white" runat="server"></asp:Label><br />
            <hr class="bg-white" />
            <strong>Nombre:</strong> <asp:Label ID="lblNombre" CssClass="text-white" runat="server"></asp:Label><br />
            <hr class="bg-white" />
            <strong>Descripción:</strong> <asp:Label ID="lblDescripcion" CssClass="text-white" runat="server"></asp:Label><br />
            <hr class="bg-white" />
            <strong>Marca:</strong> <asp:Label ID="lblMarca" CssClass="text-white" runat="server"></asp:Label><br />
            <hr class="bg-white" />
            <strong>Categoría:</strong> <asp:Label ID="lblCategoria" CssClass="text-white" runat="server"></asp:Label><br />
            <hr class="bg-white" />
            <strong>Precio:</strong> <asp:Label ID="lblPrecio" CssClass="text-white" runat="server"></asp:Label><br />
        </div>
    </div>
</div>






</asp:Content>
