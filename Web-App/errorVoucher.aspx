<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="errorVoucher.aspx.cs" Inherits="Web_App.errorVoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href='<%= ResolveUrl("~/Content/estilos.css") %>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr>
    <div> <h2> Lo sentimos! :( tu voucher no es correcto o ya fue utilizado anteriormente</h2></div>
    
    <div> <a href="CanjeoVoucher.aspx">Reintentar canjear tu voucher!</a> </div>
    
</asp:Content>
