<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validaciones.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <script type="text/javascript">
        function leerOcultos() {
            alert(document.getElementById("OcultoNombre").getAttribute("value")
                + "\n" + document.getElementById("OcultoPerfil").getAttribute("value"));

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       Nombre: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Apellido: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="NET" />
       <asp:CheckBox ID="CheckBox2" runat="server" Text="PHP" />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="JAVA" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="ACEPTAR" OnClick="Button1_Click" OnClientClick="leerOcultos()" />
        <br />
        <span id="nombreCompleto" runat="server"></span>
        <br />
        <span id="perfilCompleto" runat="server"></span>

    </div>
    </form>
</body>
</html>
