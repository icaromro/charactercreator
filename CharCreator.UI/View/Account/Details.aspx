<%@ Page Title="Detalhes do Usuário" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Details.aspx.cs" Inherits="CharCreator.UI.View.Account.Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
        
    <b>Nome: </b><asp:Label runat="server" ID="lblNome"/><br/>
    <b>Login: </b><asp:Label runat="server" ID="lblLogin"/><br/>
    <b>Data do cadastro: </b><asp:Label runat="server" ID="lblRegisterDate"/>
</asp:Content>
