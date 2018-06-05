<%@ Page Language="C#" Title="Inicia Sesion" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <!----login----->
        <div class="col-md-4 offset-md-1 card border-primary">

            <div class="form-group">
                <asp:Label Text="Nombre de usuario" ID="lblname" CssClass="control-label" runat="server" />
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control"/>
            </div>

            <div class="form-group">
                <asp:Label Text="Contraseña" ID="lblpass" CssClass="control-label" runat="server" />
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control"/>
            </div>

            <div class="form-group custom-checkbox custom-control">
                <input type="checkbox" class="custom-control-input" id="remember">
                <label class="custom-control-label" for="remember">Remember me</label>
            </div>

            <div class="form-group">
                 <asp:Button Text="Ingresar" CssClass="btn btn-primary" runat="server" OnClick="Login_Click"/>
            </div>
                <asp:Label Text="" ID="error" CssClass="text-danger control-label" runat="server" />
        </div>

        <!----msm----->
        <div class="col-md-4 offset-md-1">
            <h2>Inicio de sesion</h2>
            <hr />
            <div class="alert alert-info">
                <p>Los datos ingresados se compararan con un archivo de texto que funciona como base de datos</p>
                <p>si encuentra conicidencias entonces permitira el inicio de secion</p>
                <p>si no, entonces mandara un mensaje de error</p>
            </div>
        </div>
    </div>

</asp:Content>
