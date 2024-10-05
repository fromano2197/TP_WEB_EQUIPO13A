<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CanjeoVoucher.aspx.cs" Inherits="Web_App.CanjeoVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr>
        <div class="row g-3 align-items-center">
  <div class="col-auto">
    <label for="txtVoucher" class="col-form-label">Ingresa el Voucher</label>
  </div>
  <div class="col-auto">
    <asp:TextBox ID="txtVoucher" CssClass="form-control" placeholder="XXXXXXXXX" runat="server"></asp:TextBox>
  </div>
  <div class="col-auto">
     <asp:Button ID="btnValidar" CssClass="btn btn-primary" OnClick="btnValidar_Click" runat="server" Text="Validar" />
  </div>
</div>
</asp:Content>
