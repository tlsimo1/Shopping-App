<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="e_commerce2.Pages.Acount.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Literal ID="ltlStatus" runat="server"></asp:Literal>
<br />
<br />
    <strong>User Name :</strong><br />
<asp:TextBox ID="txtUserName" CssClass="form-control" runat="server" Width="180px"></asp:TextBox>
<br />
<br />
    <strong>Password :</strong><br />
<asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" Width="180px"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" CssClass="btn btn-default" OnClick="btnLogin_Click" Text="Button" Width="80px" />
<br />
<br />
</asp:Content>
