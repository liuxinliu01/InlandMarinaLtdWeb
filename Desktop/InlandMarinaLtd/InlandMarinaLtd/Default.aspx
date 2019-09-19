<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InlandMarinaLtd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbo">
        <h1 class="text-center">
            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/Images/inlandmarina_banner.jpg" Width="800px" />
        </h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Welcome to Inland Marina</h2>
            <p>
                Inland Marina located on the south shore Inland Lake, just a small commute from major centers in the south west. Inland Marina was established in the 1967 shortly after Inland Lake was created as a result of the South West damn. From its humble beginnings, it has grown to be the largest marina on Inland Lake. Due to the warm climate that extends year-round, Inland Lake has become a popular tourist destination in the south west. Boat owners from California, Arizona, Nevada, and Utah are attracted to the area. Inland Marina has 90 slips ranging in size from 16 to 32 feet in length. Dock services include electrical and fresh water.</p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
