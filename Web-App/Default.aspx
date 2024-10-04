<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_App.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-3 align-items-center">
  <div class="col-auto">
    <label for="inputPassword6" class="col-form-label">Canjea tu Voucher</label>
  </div>
  <div class="col-auto">
    <asp:TextBox ID="txtVoucher" CssClass="form-control" placeholder="XXXXXXXXX" runat="server"></asp:TextBox>
  </div>
  <div class="col-auto">
     <asp:Button ID="btnValidar" CssClass="btn btn-primary" OnClick="btnValidar_Click" runat="server" Text="Validar" />
  </div>
</div>
    
</asp:Content>
