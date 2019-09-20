<%@ Page Title="Dock Slip" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docks_Slip.aspx.cs" Inherits="InlandMarinaLtd.Docks_Slip" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dock Slip</h2>
    <h3>Available slip by dock</h3>
<p>Dock select:</p>
<h3>
    <asp:DropDownList ID="ddlDock" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourceDock" DataTextField="Name" DataValueField="DockID" ClientIDMode="Static">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSourceDock" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDocks" TypeName="InlandMarinaLtd.App_Code.DockDB"></asp:ObjectDataSource>
</h3>
<p>
    Available slips:</p>
<p>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSourceSlip">
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSourceSlip" runat="server"></asp:ObjectDataSource>
    </p>

    <p>Use this area to provide additional information.</p>
</asp:Content>
