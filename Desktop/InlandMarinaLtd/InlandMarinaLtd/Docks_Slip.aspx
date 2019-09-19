<%@ Page Title="Dock Slip" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docks_Slip.aspx.cs" Inherits="InlandMarinaLtd.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Available slip by dock</h3>
<p>Dock select:</p>
<h3>
    <asp:DropDownList ID="ddlDock" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" SelectMethod="GetDock">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDock" TypeName="InlandMarinaLtd.App_Code.DockDB">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlDock" Name="dockID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</h3>
<p>
    Available slips:</p>
<p>
    &nbsp;</p>

    <p>Use this area to provide additional information.</p>
</asp:Content>
