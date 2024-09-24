<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="e_commerce2.Pages.Management.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ManageArticle.aspx">Add New Article</asp:LinkButton>
<br />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="AR_Ref" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnRowEditing="GridView1_RowEditing1" AllowSorting="True">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="AR_Ref" HeaderText="AR_Ref" ReadOnly="True" SortExpression="AR_Ref" />
        <asp:BoundField DataField="AR_Design" HeaderText="AR_Design" SortExpression="AR_Design" />
        <asp:BoundField DataField="FA_CodeFamille" HeaderText="FA_CodeFamille" SortExpression="FA_CodeFamille" />
        <asp:BoundField DataField="AR_UniteVen" HeaderText="AR_UniteVen" SortExpression="AR_UniteVen" />
        <asp:BoundField DataField="AR_PrixAch" HeaderText="AR_PrixAch" SortExpression="AR_PrixAch" />
        <asp:BoundField DataField="AR_PrixVen" HeaderText="AR_PrixVen" SortExpression="AR_PrixVen" />
        <asp:BoundField DataField="AR_PrixTTC" HeaderText="AR_PrixTTC" SortExpression="AR_PrixTTC" />
        <asp:BoundField DataField="AR_SuiviStock" HeaderText="AR_SuiviStock" SortExpression="AR_SuiviStock" />
        <asp:BoundField DataField="AR_Publie" HeaderText="AR_Publie" SortExpression="AR_Publie" />
        <asp:BoundField DataField="AR_Photo" HeaderText="AR_Photo" SortExpression="AR_Photo" />
    </Columns>
    <FooterStyle BackColor="#CCCC99" />
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#F7F7DE" />
    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FBFBF2" />
    <SortedAscendingHeaderStyle BackColor="#848384" />
    <SortedDescendingCellStyle BackColor="#EAEAD3" />
    <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:E_Commerce2ConnectionString %>" DeleteCommand="DELETE FROM [ARTICLEE] WHERE [AR_Ref] = @AR_Ref" InsertCommand="INSERT INTO [ARTICLEE] ([AR_Ref], [AR_Design], [FA_CodeFamille], [AR_UniteVen], [AR_PrixAch], [AR_PrixVen], [AR_PrixTTC], [AR_SuiviStock], [AR_Publie], [AR_Photo]) VALUES (@AR_Ref, @AR_Design, @FA_CodeFamille, @AR_UniteVen, @AR_PrixAch, @AR_PrixVen, @AR_PrixTTC, @AR_SuiviStock, @AR_Publie, @AR_Photo)" SelectCommand="SELECT * FROM [ARTICLEE]" UpdateCommand="UPDATE [ARTICLEE] SET [AR_Design] = @AR_Design, [FA_CodeFamille] = @FA_CodeFamille, [AR_UniteVen] = @AR_UniteVen, [AR_PrixAch] = @AR_PrixAch, [AR_PrixVen] = @AR_PrixVen, [AR_PrixTTC] = @AR_PrixTTC, [AR_SuiviStock] = @AR_SuiviStock, [AR_Publie] = @AR_Publie, [AR_Photo] = @AR_Photo WHERE [AR_Ref] = @AR_Ref">
        <DeleteParameters>
            <asp:Parameter Name="AR_Ref" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="AR_Ref" Type="String" />
            <asp:Parameter Name="AR_Design" Type="String" />
            <asp:Parameter Name="FA_CodeFamille" Type="String" />
            <asp:Parameter Name="AR_UniteVen" Type="Int32" />
            <asp:Parameter Name="AR_PrixAch" Type="Decimal" />
            <asp:Parameter Name="AR_PrixVen" Type="Decimal" />
            <asp:Parameter Name="AR_PrixTTC" Type="Int32" />
            <asp:Parameter Name="AR_SuiviStock" Type="Int32" />
            <asp:Parameter Name="AR_Publie" Type="Int32" />
            <asp:Parameter Name="AR_Photo" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="AR_Design" Type="String" />
            <asp:Parameter Name="FA_CodeFamille" Type="String" />
            <asp:Parameter Name="AR_UniteVen" Type="Int32" />
            <asp:Parameter Name="AR_PrixAch" Type="Decimal" />
            <asp:Parameter Name="AR_PrixVen" Type="Decimal" />
            <asp:Parameter Name="AR_PrixTTC" Type="Int32" />
            <asp:Parameter Name="AR_SuiviStock" Type="Int32" />
            <asp:Parameter Name="AR_Publie" Type="Int32" />
            <asp:Parameter Name="AR_Photo" Type="String" />
            <asp:Parameter Name="AR_Ref" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
<br />
<div id="div1"  >
    </div>
<asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ManageFamille.aspx">Add New Famille</asp:LinkButton>
<br />
<asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="FA_CodeFamille" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical">

    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="FA_CodeFamille" HeaderText="FA_CodeFamille" ReadOnly="True" SortExpression="FA_CodeFamille" />
        <asp:BoundField DataField="FA_Type" HeaderText="FA_Type" SortExpression="FA_Type" />
        <asp:BoundField DataField="FA_Intitule" HeaderText="FA_Intitule" SortExpression="FA_Intitule" />
        <asp:BoundField DataField="FA_UniteVen" HeaderText="FA_UniteVen" SortExpression="FA_UniteVen" />
        <asp:BoundField DataField="FA_Coef" HeaderText="FA_Coef" SortExpression="FA_Coef" />
        <asp:BoundField DataField="FA_SuiviStock" HeaderText="FA_SuiviStock" SortExpression="FA_SuiviStock" />
        <asp:BoundField DataField="FA_Garantie" HeaderText="FA_Garantie" SortExpression="FA_Garantie" />
        <asp:BoundField DataField="FA_CodeFiscal" HeaderText="FA_CodeFiscal" SortExpression="FA_CodeFiscal" />
        <asp:BoundField DataField="FA_UnitePoids" HeaderText="FA_UnitePoids" SortExpression="FA_UnitePoids" />
        <asp:BoundField DataField="FA_Publie" HeaderText="FA_Publie" SortExpression="FA_Publie" />
    </Columns>
    <FooterStyle BackColor="#CCCC99" />
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#F7F7DE" />
    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FBFBF2" />
    <SortedAscendingHeaderStyle BackColor="#848384" />
    <SortedDescendingCellStyle BackColor="#EAEAD3" />
    <SortedDescendingHeaderStyle BackColor="#575357" />
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:E_Commerce2ConnectionString2 %>" DeleteCommand="DELETE FROM [FAMILLE] WHERE [FA_CodeFamille] = @FA_CodeFamille" InsertCommand="INSERT INTO [FAMILLE] ([FA_CodeFamille], [FA_Type], [FA_Intitule], [FA_UniteVen], [FA_Coef], [FA_SuiviStock], [FA_Garantie], [FA_CodeFiscal], [FA_UnitePoids], [FA_Publie]) VALUES (@FA_CodeFamille, @FA_Type, @FA_Intitule, @FA_UniteVen, @FA_Coef, @FA_SuiviStock, @FA_Garantie, @FA_CodeFiscal, @FA_UnitePoids, @FA_Publie)" SelectCommand="SELECT * FROM [FAMILLE]" UpdateCommand="UPDATE [FAMILLE] SET [FA_Type] = @FA_Type, [FA_Intitule] = @FA_Intitule, [FA_UniteVen] = @FA_UniteVen, [FA_Coef] = @FA_Coef, [FA_SuiviStock] = @FA_SuiviStock, [FA_Garantie] = @FA_Garantie, [FA_CodeFiscal] = @FA_CodeFiscal, [FA_UnitePoids] = @FA_UnitePoids, [FA_Publie] = @FA_Publie WHERE [FA_CodeFamille] = @FA_CodeFamille">
        <DeleteParameters>
            <asp:Parameter Name="FA_CodeFamille" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FA_CodeFamille" Type="String" />
            <asp:Parameter Name="FA_Type" Type="Int16" />
            <asp:Parameter Name="FA_Intitule" Type="String" />
            <asp:Parameter Name="FA_UniteVen" Type="Int16" />
            <asp:Parameter Name="FA_Coef" Type="Decimal" />
            <asp:Parameter Name="FA_SuiviStock" Type="Int16" />
            <asp:Parameter Name="FA_Garantie" Type="Int16" />
            <asp:Parameter Name="FA_CodeFiscal" Type="String" />
            <asp:Parameter Name="FA_UnitePoids" Type="Int16" />
            <asp:Parameter Name="FA_Publie" Type="Int16" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FA_Type" Type="Int16" />
            <asp:Parameter Name="FA_Intitule" Type="String" />
            <asp:Parameter Name="FA_UniteVen" Type="Int16" />
            <asp:Parameter Name="FA_Coef" Type="Decimal" />
            <asp:Parameter Name="FA_SuiviStock" Type="Int16" />
            <asp:Parameter Name="FA_Garantie" Type="Int16" />
            <asp:Parameter Name="FA_CodeFiscal" Type="String" />
            <asp:Parameter Name="FA_UnitePoids" Type="Int16" />
            <asp:Parameter Name="FA_Publie" Type="Int16" />
            <asp:Parameter Name="FA_CodeFamille" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
<br />
</asp:Content>
