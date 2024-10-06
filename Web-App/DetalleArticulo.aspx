<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <h2 class="text-center">Detalle del Artículo</h2>
    <hr />
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <asp:Repeater ID="rptImagenes" runat="server">
                <ItemTemplate>
                    <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                        <img src='<%# Eval("ImagenUrl") %>' class="d-block w-100" walt="Imagen de Artículo">
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <div class="details-container mt-4">
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
</asp:Content>


