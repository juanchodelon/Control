<%@ Page Language="C#" Title="Home Page"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Administrador.aspx.cs" Inherits="Account_Administrador" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

        <div class="row col-sm-10 offset-sm-1 pb-5">
            <!------Crear producto------>
            <div class="col-sm-5">
                <h2>Crear producto</h2><hr />
                <div class="pb-1">
                    <small>nombre del producto</small>
                    <asp:TextBox runat="server" ID="Pname" CssClass="form-control" />  
                </div>
                <div class="row pb-1">
                    <div class="col">
                        <small>precio</small>
                        <asp:TextBox runat="server" ID="precio" CssClass="form-control" />  
                    </div>
                    <div class="col">
                        <small>existencias</small>
                        <asp:TextBox runat="server" TextMode="Number" ID="existencias" CssClass="form-control" />  
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
                <h2>modifica un produto</h2><hr />
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
                    <asp:Button Text="modificar" CssClass="btn btn-primary" runat="server" OnClick="modificar_Click"/>
                </div>
           </div>
        </div>


        
        <!----crear empleado----->
        <div class="col-md-5 offset-md-1 card border-primary">
            <h2>agrega un empleado</h2><hr/>
            <div class="form-group">
                <asp:Label Text="Nombre de usuario" ID="lblname" CssClass="control-label" runat="server" />
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control"/>
            </div>

            <div class="form-group">
                <asp:Label Text="Contraseña" ID="lblpass" CssClass="control-label" runat="server" />
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control"/>
            </div>

            <div class="form-group">
                 <asp:Button Text="Ingresar" CssClass="btn btn-primary" runat="server" OnClick="agregar_Click"/>
            </div>
                <asp:Label Text="" ID="txtsuccess" CssClass="text-success control-label" runat="server" />
            </div>
        </div>

        

        <!------muestra las estadisticas del vendedor------>
        <div class="alert alert-light col-sm-10 offset-sm-1 mt-5">
            <strong><h3>estadisticas</h3></strong><hr />
            <p><strong>en venta: </strong><asp:Label Text="" CssClass="control-label" ID="Label1" runat="server" /></p>
            <p><strong>vendidos: </strong><asp:Label Text="" CssClass="control-label" ID="Label2" runat="server" /></p>
            <p><strong>Mas pedidos: </strong><asp:Label Text="" CssClass="control-label" ID="Label3" runat="server" /></p>
            <p><strong>Ganancias: </strong><asp:Label Text="" CssClass="control-label" ID="Label4" runat="server" /></p>
        </div>


</asp:Content>
