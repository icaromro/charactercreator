<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CharCreator.UI.View.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css" media="screen">
        .jumbotronMod {
            padding-right: 60px;
            padding-left: 60px;
            width: 40%;
            background: lightgrey;                        
        }    
    </style>
</head>
<body>
<form id="form1" runat="server">
    <br/>
    <div class="jumbotronMod" align="center" >        
        <h2><%: Title %></h2>        

        <address>
            <strong>Login:</strong> <asp:TextBox CssClass="input-sm" runat="server" ID="txbLogin"></asp:TextBox><br />
            <strong>Senha:</strong> <asp:TextBox CssClass="input-sm" runat="server" TextMode="Password" ID="txbPassword"></asp:TextBox> 
        </address>
                     
        <asp:Button runat="server" CssClass="btn-lg" BackColor="LightGreen" ID="btnLogin" Text="Entrar" OnClick="btnLogin_OnClick"/>  
        <br/>
    </div>
</form>
</body>
</html>

