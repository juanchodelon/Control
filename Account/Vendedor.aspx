<%@ Page Language="C#" Title="Vendedor" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Vendedor.aspx.cs" Inherits="Account_Vendedor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="hi" CssClass="h3"></asp:Label><hr />
    <div class="row">
        
        <!-------formulario para vender a un cliente------>
        <div class="col-sm-5 offset-sm-1">
            <h2>Vende uno de tus productos!</h2><hr />
            <div class="row pb-1">
                <div class="col-sm-8">
                    <small>Nit del cliente</small>
                    <asp:TextBox runat="server" ID="txtnit" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col pt-4">
                    <asp:Button runat="server" Text="verificar NIT" ID="btnverificar" CssClass="btn btn-primary" OnClick="btnverificar_Click"/>
                </div>
            </div>
            
            <div class="row pb-1">
                <div class="col">
                    <small>Codigo del producto</small>
                    <asp:TextBox runat="server" ID="codigoprod" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col">
                    <small>cantidad a pedir</small>
                    <asp:TextBox runat="server" ID="cantidad" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
            </div>
            
            <div class="pb-3">
                <small>cantidad con que va a pagar</small>
                <asp:TextBox runat="server" ID="txtpago" CssClass="form-control" TextMode="Number"></asp:TextBox>
                <small><asp:Label runat="server" ID="succesvuelto" CssClass="text-success">cambio: </asp:Label></small>
            </div>
            <div class="pb-3">
                <asp:Button runat="server" Text="comprar producto" ID="comprar" CssClass="btn btn-primary" OnClick="comprar_Click1"/>
            </div>
        </div>

        <!----formulario para agregar clientes---->
            <div class="col-sm-4 offset-sm-1 border border-primary">
                <h2 class="pt-3">Crear cliente</h2><hr />
                <div class="pb-1">
                    <small>nombre del Cliente</small>
                    <asp:TextBox runat="server" ID="cnombre" CssClass="form-control" />  
                </div>
                <div class="pb-1">
                    <small>NIT</small>
                    <asp:TextBox runat="server" ID="cnit" CssClass="form-control" />  
                </div>
                <div class="pb-4">
                    <small>Telefono</small>
                    <asp:TextBox runat="server" ID="ctelefono" CssClass="form-control" />  
                </div>
                <div class="pb-4">
                    <asp:Button runat="server" Text="Crear cliente" ID="BtnaddCliente" CssClass="btn btn-primary" OnClick="BtnaddCliente_Click"/>
                </div>
            </div>

        <!-----verificacion del cliente------>
        <div class="col-sm-10 offset-sm-1 pt-3">
            <p><asp:Label runat="server" ID="txnit"></asp:Label></p>
            <p><asp:Label runat="server" ID="txtnombre"></asp:Label></p>
            <p><asp:Label runat="server" ID="txttelefono"></asp:Label></p>
            <p><asp:Label runat="server" ID="txterror" CssClass="text-danger"></asp:Label></p>
            <p><asp:Label runat="server" ID="txtsucces" CssClass="text-success"></asp:Label></p>
        </div>

    </div>
</asp:Content>