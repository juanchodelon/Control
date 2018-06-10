<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Inicio</h1>
    </div>
    
        <!------muestra la lista de productos en venta------>
        <div class="col-sm-10 offset-sm-1">
            <h2>tus productos</h2><hr />
            <asp:DataGrid ID="pgrid" runat="server" CssClass="table table-striped shadow p-3 mb-5 bg-white rounded" ></asp:DataGrid>
        </div>

</asp:Content>
