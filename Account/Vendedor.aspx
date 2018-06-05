<%@ Page Language="C#" Title="Vendedor" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Vendedor.aspx.cs" Inherits="Account_Vendedor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <!------formularios para vendedores------>
        <div class="row col-sm-10 offset-sm-1">
            <!------Crear producto------>
            <div class="col-sm-5">
                <strong>Crear producto</strong><hr />
                <div class="pb-1">
                    <small>nombre del producto</small>
                    <asp:TextBox runat="server" ID="Pname" CssClass="form-control" />  
                </div>
                <div class="row pb-1">
                    <div class="col">
                        <small>precio</small>
                        <asp:TextBox runat="server" ID="precio" CssClass="form-control" TextMode="Number" />  
                    </div>
                    <div class="col">
                        <small>existencias</small>
                        <asp:TextBox runat="server" ID="existencias" CssClass="form-control" TextMode="Number" />  
                    </div>
                </div>
                <div class="pb-1">
                    <small>categoria</small>
                    <asp:DropDownList ID="category" CssClass="form-control" runat="server">
                      <asp:ListItem>Selecciona una categoria</asp:ListItem>
                      <asp:ListItem>Vehiculos</asp:ListItem>
                      <asp:ListItem>Propiedades</asp:ListItem>
                      <asp:ListItem>animales-mascotas</asp:ListItem>
                      <asp:ListItem>Electronicos</asp:ListItem>
                      <asp:ListItem>moda</asp:ListItem>
                      <asp:ListItem>Trabajo</asp:ListItem>
                      <asp:ListItem>servicios</asp:ListItem>
                      <asp:ListItem>hobbies-arte-musica</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="pb-3">
                    <small>descripcion</small>
                    <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" />  
                </div>
                <div class="form-group">
                     <asp:Button Text="Crear producto" CssClass="btn btn-primary" runat="server" OnClick="Crear_Click"/>
                </div>
            </div>
            <!------editar un producto------>
            <div class="col-sm-5 offset-sm-1">
                <strong>modifica un produto</strong><hr />
                <div class="pb-1">
                    <small>codigo del produto</small> 
                    <asp:TextBox runat="server" ID="Codigo" CssClass="form-control" /> 
                </div>
                <div class="pb-1">
                    <small>nombre del producto</small>
                    <asp:TextBox runat="server" ID="nuevonombre" CssClass="form-control" />  
                </div>
                <div class="row pb-1">
                    <div class="col-sm">
                        <small>precio</small>
                        <asp:TextBox runat="server" ID="nuevoprecio" CssClass="form-control" TextMode="Number" />  
                    </div>
                    <div class="col-sm">
                        <small>existencias</small>
                        <asp:TextBox runat="server" ID="nuevoexist" CssClass="form-control" TextMode="Number" />  
                    </div>
                </div>
                <div class="pb-3">
                    <small>descripcion</small>
                    <asp:TextBox runat="server" ID="nuevadescrip" CssClass="form-control" />  
                </div>
                <div class="form-group">
                    <asp:Button Text="modificar" CssClass="btn btn-primary" runat="server"/>
                </div>
           </div>
        </div>
        <!------muestra la lista de productos en venta------>
        <div class="col-sm-10 offset-sm-1 pt-5">
            <h2>tus productos</h2><hr />
            <asp:DataGrid ID="pgrid" runat="server" CssClass="table table-striped shadow p-3 mb-5 bg-white rounded" ></asp:DataGrid>
        </div>

        <!------muestra la informacion personal del usuario------>
        <div class="alert alert-light col-sm-4 offset-sm-1 pt-5">
            <strong>Informacion Personal</strong><hr />
            <p><strong>Usuario: </strong><asp:Label Text="" CssClass="control-label" ID="name" runat="server" /></p>
            <p><strong>correo: </strong><asp:Label Text="" CssClass="control-label" ID="correo" runat="server" /></p>
            <p><strong>numero telefonico: </strong><asp:Label Text="" CssClass="control-label" ID="phone" runat="server" /></p>
            <p><strong>empresa: </strong><asp:Label Text="" CssClass="control-label" ID="empresa" runat="server" /></p>
        </div>

        <!------muestra las estadisticas del vendedor------>
        <div class="alert alert-light col-sm-6 pt-5">
            <strong>estadisticas</strong><hr />
            <p><strong>en venta: </strong><asp:Label Text="" CssClass="control-label" ID="Label1" runat="server" /></p>
            <p><strong>vendidos: </strong><asp:Label Text="" CssClass="control-label" ID="Label2" runat="server" /></p>
            <p><strong>Mas pedidos: </strong><asp:Label Text="" CssClass="control-label" ID="Label3" runat="server" /></p>
            <p><strong>Ganancias: </strong><asp:Label Text="" CssClass="control-label" ID="Label4" runat="server" /></p>
        </div>
    </div>

</asp:Content>