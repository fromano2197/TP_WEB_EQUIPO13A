<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
    <hr />
    <h2 class="text-center">Detalle del Artículo</h2>
    <hr />

    <div class="d-flex justify-content-center">

        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="max-width: 50%;">
            <div class="carousel-inner">
                <asp:Repeater ID="rptImagenes" runat="server">
                    <ItemTemplate>
                        <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                     
                            <img src='<%# Eval("ImagenUrl") %>' class="d-block w-100 img-fluid" alt="Imagen de Artículo">
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
    </div>

    <div class="d-flex justify-content-center mt-4">
        <div class="bg-primary bg-gradient text-white p-3 rounded" style="max-width: 50%;">
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

    <div class="d-flex justify-content-center mt-4 flex-column align-items-center">
        <a class="btn btn-primary" style="width: 200px; height: 50px; font-size: 16px; margin-bottom: 10px;" href="ArticuloLista.aspx">Volver a la Lista</a>
        <a class="btn btn-success" style="width: 200px; height: 50px; font-size: 16px;" href="DatosCliente.aspx?id=<%# Eval("Id") %>">Canjear</a>
    </div>
</asp:Content>
