<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="Web_App.DatosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="form-wrapper">
            <form class="row g-3">
                <h1>Ingresá tus datos</h1>
                
                <div class="col-md-6">
                    <label for="txtDni" class="form-label">DNI</label>
                    <asp:TextBox runat="server" ID="txtDni" CssClass="form-control" />
                </div>
                
                <div class="col-md-6">
                    <label for="txtNombre" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                </div>
                
                <div class="col-md-6">
                    <label for="txtApellido" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                </div>
                
                <div class="col-md-6">
                    <label for="txtEmail" class="form-label">Email</label>
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email" />
                </div>
                
                <div class="col-12">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" placeholder="Calle, Número" />
                </div>
                
                <div class="col-md-6">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" />
                </div>
                
                <div class="col-md-6">
                    <label for="txtCodigoPostal" class="form-label">Código Postal</label>
                    <asp:TextBox runat="server" ID="txtCodigoPostal" CssClass="form-control" />
                </div>
                
                <div class="col-12">
                    <asp:Button runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" />
                </div>
                <div class="col-12"> 
                    <asp:Literal ID="litAlerta" runat="server"></asp:Literal>
                </div>
                
            </form>
        </div>
    </div>
</asp:Content>
