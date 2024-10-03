<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="Web_App.DatosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Ingresá tus datos</h1>
    <form class="row g-3">
        <div class="col-md-6">
            <label for="inputDNI" class="form-label">DNI</label>
            <input type="text" class="form-control" id="inputDNI">
        </div>
        <div class="col-md-6">
            <label for="inputNombre" class="form-label">Nombre</label>
            <input type="text" class="form-control" id="inputNombre">
        </div>
        <div class="col-md-6">
            <label for="inputApellido" class="form-label">Apellido</label>
            <input type="text" class="form-control" id="inputApellido">
        </div>
        <div class="col-md-6">
            <label for="inputEmail" class="form-label">Email</label>
            <input type="email" class="form-control" id="inputEmail">
        </div>
        <div class="col-12">
            <label for="inputDireccion" class="form-label">Dirección</label>
            <input type="text" class="form-control" id="inputDireccion" placeholder="Calle, Número">
        </div>
        <div class="col-md-6">
            <label for="inputCiudad" class="form-label">Ciudad</label>
            <input type="text" class="form-control" id="inputCiudad">
        </div>
        <div class="col-md-6">
            <label for="inputCodigoPostal" class="form-label">Código Postal</label>
            <input type="text" class="form-control" id="inputCodigoPostal">
        </div>
        <div class="col-12">
            <button type="submit" class="btn btn-primary">Enviar</button>
        </div>
    </form>



</asp:Content>
