<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_Sencillo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insertar, Consultar y Eliminar en ASP.NET SQl Server y Bootstrap</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Assets/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Assets/js/jquery-1.10.2.min.js"></script>
    <script src="Assets/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="jumbotron" style="padding:20px;text-align:center">
            <h1>Insertar, Consultar y Eliminar en ASP.NET SQl Server y Bootstrap</h1>
            <p class="lead">Este es un ejemplo de como hacer una aplicación con ASP.NET para Insertar, Consultar, Eliminar y Actualizar Datos.</p>
        </div>

        <div class="row">
            <div class="col-md-4" style="text-align:center">
                <div class="well">
                    <h4>Insertar nuevo registro</h4><hr />
                    <p><asp:Label ID="LblGuardar" runat="server"></asp:Label></p>
                    <p><i class="glyphicon glyphicon-user"></i> Nombre:</p>
                    <p><asp:TextBox ID="TxtNombre" runat="server" style="margin:0 auto" CssClass="form-control" Width="200px"></asp:TextBox></p>
                    <p>Apellido:</p>
                    <p><asp:TextBox ID="TxtTelefono" runat="server" style="margin:0 auto" CssClass="form-control" Width="200px" ></asp:TextBox></p>
                    <p>email:</p>
                    <p><asp:TextBox ID="TxtCiudad" runat="server" style="margin:0 auto" CssClass="form-control" Width="200px"></asp:TextBox></p>
                    <p>Sexo:</p>
                    <p><asp:TextBox ID="TxtCiudad0" runat="server" style="margin:0 auto" CssClass="form-control" Width="200px"></asp:TextBox></p>
                    <p>Password:</p>
                    <p><asp:TextBox ID="TxtCiudad1" TextMode="Password" runat="server" style="margin:0 auto" CssClass="form-control" Width="200px"></asp:TextBox></p>
                    <p><asp:Button ID="BtnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar Registro" OnClick="BtnGuardar_Click" /></p>
                </div>
            </div>
            <div class="col-md-4" style="text-align:center">
                <h4>Consulta desde la BD al cargar la página</h4><hr />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </div>
            <div class="col-md-4" style="text-align:center">
                <h4>Escoge el registro que desees eliminar</h4><hr />
                <p><asp:Label ID="LblEliminar" runat="server"></asp:Label></p>
                <p><asp:DropDownList ID="CmbRegistro" CssClass="form-control" runat="server"></asp:DropDownList></p>
                <p><asp:Button ID="BtnEliminar" runat="server" CssClass="btn btn-primary" Text="Eliminar Registro" OnClick="BtnEliminar_Click" /></p>
            </div>
        </div>
    </div>
    </form>
</body>
</html>