<%@ Page Title="Lista de Personagens" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CharacterList.aspx.cs" Inherits="CharCreator.UI.View.Character.CharacterList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css" media="screen">
        
    </style>
    
    <h2><%: Title %></h2>
        <br/>    
    <asp:Button runat="server" CssClass="btn-xs" Text="Criar Novo" ID="btnCreateCharacter" OnClick="btnCreateCharacter_OnClick"/>
    <br/><br/>
    <asp:GridView runat="server" CssClass="table-responsive" ShowHeaderWhenEmpty="True" ShowHeader="True" ID="gvCharacters" 
        EmptyDataText="Você ainda não criou nenhum personagem" DataKeyNames="id"
        OnRowCommand="gvCharacters_OnRowCommand">
        <Columns>
            <asp:BoundField DataField="system_name" HeaderText="Sistema"/>
            <asp:BoundField DataField="name" HeaderText="Nome"/>
            <asp:BoundField DataField="register_date" HeaderText="Data de Criação" dataformatstring="{0:dd/MM/yyyy}"/>            
            <asp:buttonfield HeaderText="Visualizar" buttontype="button" Text="Visualizar" commandname="viewCharacter"  />
        </Columns>
    </asp:GridView>          
    
</asp:Content>
