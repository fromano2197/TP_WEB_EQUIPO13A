<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_App.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr>
    <h1>Bienvenido a Promo gana!</h1>
    <asp:Button ID="btnVoucher" runat="server" Text="Canjea tu voucher!" CssClass="btn btn-primary" type="button" OnClick="btnVoucher_Click"  />
 
</asp:Content>
