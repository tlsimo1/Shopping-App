<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="ManageArticle.aspx.cs" Inherits="e_commerce2.Pages.Management.ManageArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 130px;
    }
    .auto-style3 {
            width: 122px;
            text-align: right;
            font-weight: bold;
        }
    .auto-style4 {
            width: 130px;
            text-align: right;
            font-weight: bold;
        }
    .auto-style5 {
        width: 130px;
        text-align: right;
        height: 26px;
            font-weight: bold;
        }
    .auto-style6 {
        width: 130px;
        height: 26px;
    }
    .auto-style7 {
        width: 122px;
        text-align: right;
        height: 26px;
    }
    .auto-style8 {
        height: 26px;
    }
        .auto-style9 {
            width: 130px;
            text-align: right;
            height: 62px;
            font-weight: bold;
        }
        .auto-style10 {
            width: 130px;
            height: 62px;
        }
        .auto-style11 {
            width: 122px;
            text-align: right;
            height: 62px;
            font-weight: bold;
        }
        .auto-style12 {
            height: 62px;
        }
        .auto-style13 {
            color: #fff;
            background-color: #5cb85c;
            border-color: #4cae4c;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style4">AR_Ref :</td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
        <td class="auto-style3">AR_PrixTTC :</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">AR_Design :</td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox2" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
        <td class="auto-style3">AR_SuiviStock :</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">FA_CodeFamille :</td>
        <td class="auto-style10">
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="FA_CodeFamille" DataValueField="FA_CodeFamille">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:E_Commerce2ConnectionString %>" SelectCommand="SELECT [FA_CodeFamille] FROM [FAMILLE] ORDER BY [FA_CodeFamille]"></asp:SqlDataSource>
        </td>
        <td class="auto-style11">AR_Publie :</td>
        <td class="auto-style12">
            <asp:TextBox ID="TextBox8" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">AR_UniteVent :</td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox3" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
        <td class="auto-style3">AR_Photo :</td>
        <td>
            <asp:DropDownList ID="DropDownList2" CssClass="dropdown" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">AR_PrixAch :</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox4" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 0px" Text="Submit" CssClass="auto-style13" Width="80px" />
        </td>
        <td class="auto-style8">
            <asp:Label ID="Label1" runat="server" CssClass="label-info" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">AR_PrixVen :</td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox5" runat="server" CssClass=" form-control" Width="140px"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
