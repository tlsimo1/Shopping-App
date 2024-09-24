<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="e_commerce2.Pages.Acount.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
</p>
<p>
    <strong>User Name :</strong></p>
<p>
    <asp:TextBox ID="txtUserName" CssClass=" form-control" runat="server" Width="140px"></asp:TextBox>
</p>
<p>
    <strong>Password :</strong></p>
<p>
    <asp:TextBox ID="txtPassword" runat="server"  CssClass=" form-control" TextMode="Password" Width="140px"></asp:TextBox>
</p>
<p>
    <strong>Confirm Password :</strong></p>
<p>
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass=" form-control" TextMode="Password" Width="140px"></asp:TextBox>
</p>
    <p>
        <strong>First Name :</strong></p>
    <p>
    <asp:TextBox ID="txtFirstName" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
</p>
    <p>
        <strong>Last Name :</strong></p>
    <p>
    <asp:TextBox ID="txtLastName" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
</p>
    <p>
        <strong>Adress :</strong></p>
    <p>
    <asp:TextBox ID="txtAdress" runat="server"  CssClass=" form-control" TextMode="MultiLine" Width="140px"></asp:TextBox>
</p>
    <p>
        <strong>Postal Code :</strong></p>
    <p>
    <asp:TextBox ID="txtPostalCode" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" OnClick="Button1_Click" Text="Button" />
</p>
</asp:Content>
