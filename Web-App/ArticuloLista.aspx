<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticuloLista.aspx.cs" Inherits="Web_App.ArticuloLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvArticulos" runat="server" CssClass="table"></asp:GridView>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%
            foreach (dominio.Articulo art in ListaArticulo)
            {
        %>

        <div class="col">
            <div class="card">
                <img src="<%: art.UrlImagen %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%: art.Nombre %></h5>
                    <p class="card-text"> <%: art.Descripcion %> </p>
                    <a href=DetalleArticulo.aspx?id="<%: art.Id %>">Ver Detalle</a>
                </div>
            </div>
        </div>
        <%
            }
        %>
    </div>
</asp:Content>
