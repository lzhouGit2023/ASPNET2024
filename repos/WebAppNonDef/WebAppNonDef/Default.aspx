<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppNonDef._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
            <label>Username</label>
            <textbox></textbox>
        <label>Password</label>
        <textbox></textbox>
         <asp:Button runat="server"/>
    </div>
    <asp:Literal ID ="dbOut" runat ="server" />  
</asp:Content>
