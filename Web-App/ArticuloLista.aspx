<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ArticuloLista.aspx.cs" Inherits="Web_App.ArticuloLista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
     
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="dgvArticulos" runat="server" CssClass="table"></asp:GridView>
    <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
     <hr />
    <div class="row row-cols-1 row-cols-md-3 g-4">
      <asp:Repeater ID="repRepeater" runat="server">
<ItemTemplate>
    <div class="col">
        <div class="card">
            <img src="<%# Eval("UrlImagen") %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title">"<%# Eval("Nombre") %>"</h5>
                <p class="card-text">"<%# Eval("Descripcion") %>"</p>
                <div class="d-flex flex-column">
                    <a class="btn btn-primary mb-2" href="DetalleArticulo.aspx?id=<%# Eval("Id") %>">Ver Detalle</a>
                    <%--<a class="btn btn-success" href="DatosCliente.aspx?id=<%# Eval("Id") %>">Canjear</a>--%>
                </div>
            </div>
        </div>
    </div>
</ItemTemplate>


    </asp:Repeater>

        
       
    </div>
</asp:Content>
