<%@ Page Title="CharacterList" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="CharacterList.aspx.cs" Inherits="CharCreator.UI.View.Character.CharacterList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css" media="screen">
        
    </style>
        <br/>
    <asp:GridView runat="server" CssClass="table-responsive" ShowHeader="True" ID="gvCharacters" EmptyDataText="Você ainda não criou nenhum personagem">
        <Columns>
            <asp:BoundField DataField="system_name" HeaderText="Sistema"/>
            <asp:BoundField DataField="character_name" HeaderText="Nome"/>
        </Columns>
    </asp:GridView>
    
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>
    
</asp:Content>
