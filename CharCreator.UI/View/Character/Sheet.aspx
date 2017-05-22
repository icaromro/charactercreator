<%@ Page Title="Gerência de Personagens" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Sheet.aspx.cs" Inherits="CharCreator.UI.View.Character.Sheet" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css" media="screen">
        
        </style>
    
    <h2><asp:Label runat="server" ID="lblTitle"/></h2>
    <br/>
    Selecione o sistema: <asp:DropDownList runat="server" ID="ddlSystem" DataTextField="name" DataValueField="id" /> 
    <asp:Button runat="server" ID="btnSelectSystem" OnClick="btnSelectSystem_OnClick" Text="Selecionar"/> <asp:Button runat="server" ID="btnDeselectSystem" OnClick="btnDeselectSystem_OnClick" Text="Selecionar outro sistema" Visible="False" OnClientClick="return confirm('Tem certeza que deseja selecionar outro sistema? Todos os dados do personagens serão perdidos.');"/>
    <br/><br/>

    
    
</asp:Content>