<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_App.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center"> 
        <h2 class="h2">Bienvenido a Promo ganá!</h2>
    </div>
    <img src="https://cloudmlmsoftware.com/sites/all/themes/cloudmlm/assets/images/features/evoucherIntro.webp" class="rounded mx-auto d-block" alt="">
    <hr>
    <div class="d-grid gap-2 col-2 mx-auto">
  <asp:Button ID="btnVoucher" runat="server" Text="Canjea tu voucher!" CssClass="btn btn-primary btn-lg" type="button" OnClick="btnVoucher_Click"  />
</div>
 
</asp:Content>
