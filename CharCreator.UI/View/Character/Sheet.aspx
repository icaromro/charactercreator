﻿<%@ Page Title="Gerência de Personagens" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Sheet.aspx.cs" Inherits="CharCreator.UI.View.Character.Sheet" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css" media="screen">
        
        </style>
    
    <h2><asp:Label runat="server" ID="lblTitle"/></h2>
    <br/>
    Selecione o sistema: <asp:DropDownList runat="server" ID="ddlSystem" DataTextField="name" DataValueField="id" OnInit="ddlSystem_OnInit" /> 
    <asp:Button runat="server" ID="btnSelectSystem" OnClick="btnSelectSystem_OnClick" Text="Selecionar"/> <asp:Button runat="server" ID="btnDeselectSystem" OnClick="btnDeselectSystem_OnClick" Text="Selecionar outro sistema" Visible="False" OnClientClick="return confirm('Tem certeza que deseja selecionar outro sistema? Todos os dados do personagens serão perdidos.');"/>
    <br/><br/>

    <asp:MultiView runat="server" ID="mvCharacterSheets" >
        <Views>
            <asp:View runat="server" ID="blankView" ></asp:View>
            <asp:View runat="server" ID="view3deT">
                <div class="row">
                    <div class="col-lg-2"><b>Nome: </b></div>
                    <div class="col"><asp:TextBox runat="server" ID="txbName"  Width="350px"/></div>                    
                </div>
                <div class="row">
                    <div class="col-lg-2" ><b>Pontos de Personagem: </b></div>
                    <div class="col"><asp:Label runat="server" ID="lblPoints" Text="0" /></div>
                </div>
                <div class="row">
                    <div class="col-lg-2"><b>Escala de Poder: </b></div>
                    <div class="col"><asp:DropDownList runat="server" ID="ddlScale" DataTextField="name" DataValueField="id" OnInit="ddlScale_OnInit" /></div>
                </div>                           
                <div class="row">
                    <div class="col-lg-2"><b><asp:Label ID="lblRace" runat="server">Raça: </asp:Label></b></div>
                    <div class="col">
                        <asp:Button ID="btnRace" runat="server" Text="Humano" ToolTip="Clique para selecionar"/>                        
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-2"><b>Sexo: </b></div>
                    <div class="col"><asp:DropDownList runat="server" ID="ddlSex" >
                        <asp:ListItem Text="Selecione" Value="-1"/>
                        <asp:ListItem Text="Macho" Value="M"/>
                        <asp:ListItem Text="Fêmea" Value="F"/>
                    </asp:DropDownList></div>
                </div>     
                <div class="row">
                    <div class="col-lg-2"><b><asp:Label ID="lblKit" runat="server">Classe: </asp:Label></b></div>
                    <div class="col">
                        <asp:Button runat="server" ID="btnKit" Text="Selecione" ToolTip="Clique para selecionar"/>
                    </div>
                </div>
                <div class="row"><h3>Atributos</h3></div>
                <div class="row">
                    <asp:GridView runat="server" ID="gvAttributes" ShowHeader="False" OnRowCommand="gvAttributes_OnRowCommand"
                        DataKeyNames="id, description" AutoGenerateColumns="False" BorderWidth="0">
                        <Columns>                            
                            <asp:BoundField HeaderText="Nome" DataField="name"/>
                            <asp:buttonfield buttontype="button" Text="?" HeaderText="Descrição" commandname="description" />
                            <asp:BoundField HeaderText="Valor" DataField="value"/>                                     
                            <asp:buttonfield HeaderText="Adicionar" buttontype="button" Text="+" commandname="add" />
                            <asp:buttonfield HeaderText="Subtrair" buttontype="button" Text="-" commandname="sub" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="row">
                    <div class="col-lg-2"><b>Pontos de Vida: </b> </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="txbCurrentHealth" Text="1"  Width="40px"/>
                        <b style="font-size: large">/ <asp:Label ID="lblMaxHealth" Text="1" runat="server"/></b>
                    </div>
                </div>
                
                <div class="row">
                    <div class="col-lg-2"><b>Pontos de Mana: </b> </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="txbCurrentMana" Text="1" Width="40px"/>
                        <b style="font-size: large">/ <asp:Label ID="lblMaxMana" Text="1" runat="server"/></b>
                        
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-2"><b>Pontos de Experiência: </b> </div>
                    <div class="col"><asp:TextBox runat="server" ID="txbExperiencePoint" Width="40px" Text="0" ></asp:TextBox></div>
                </div>                                              
                <div class="row">
                    <div class="col-lg-2"><b>Histórico: </b> </div>
                    <div class="col"><asp:TextBox runat="server" ID="txbBackground" TextMode="MultiLine" Rows="5" Width="500px"></asp:TextBox></div>
                </div>
            </asp:View>
        </Views>
        
    </asp:MultiView>
    
</asp:Content>