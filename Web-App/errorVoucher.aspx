<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="errorVoucher.aspx.cs" Inherits="Web_App.errorVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr>
    <h1>Tu voucher no es correcto o ya fue utilizado anteriormente!</h1>
    <a href="CanjeoVoucher.aspx">Canjea tu voucher!</a>
</asp:Content>
