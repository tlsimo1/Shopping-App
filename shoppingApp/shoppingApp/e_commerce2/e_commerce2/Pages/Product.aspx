<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="e_commerce2.Pages.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr>
            <td rowspan="4">

                <asp:Image ID="imgProduct" runat="server" Height="400px" Width="400px"  />
            </td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" ></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label><br />
                Quantity:<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                <asp:Button ID="btnAdd" runat="server"  CssClass="btn btn-success" OnClick="btnAdd_Click" Text="Add Product" />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td> Reference Article :
                <br />
                <asp:Label ID="lblItemNr" runat="server" Style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;<asp:Label ID="lblAvailable" runat="server" CssClass="productPrice">Available!</asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
