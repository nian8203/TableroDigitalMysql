<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TableroDigitalV001.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
            <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:LinkButton ID="btnIniciarSesion" runat="server" Text="" OnClick="btnIniciarSesion_Click">Iniciar Sesión<i class="material-icons right">send</i></asp:LinkButton>

        </div>
    </form>

     <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
   
</body>
</html>
