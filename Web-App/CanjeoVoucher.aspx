<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CanjeoVoucher.aspx.cs" Inherits="Web_App.CanjeoVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>'
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr>

    <form class="row g-3">
  <div class="d-grid gap-6 col-6 mx-auto">
      <label for="txtVoucher" class="form-label"> Codigo Voucher</label>
<asp:TextBox ID="txtVoucher" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="d-grid gap-6 col-6 mx-auto">
       <asp:Button ID="btnValidar" CssClass="btn btn-primary"  OnClick="btnValidar_Click" runat="server" Text="Validar"/>
  </div>
</form>
 
</asp:Content>
