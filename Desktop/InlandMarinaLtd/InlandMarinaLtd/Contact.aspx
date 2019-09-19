<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="InlandMarinaLtd.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Information.</h3>
    <address>
        Inland Lake Marina<br />
        Box 123<br />
        Inland Lake, Arizona<br />
        86038<br />
        425.555.0100(office ph) 928-450-2234<br />
        (leasing ph) 928-450-2235<br />
        (fax) 928-450-2236<br />
        Manager: Glenn Cooke<br />
        Slip Manager: Kimberley Carson<br />
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a>
    </address>
</asp:Content>
