<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="fase1.pagina.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>
<body>

<form action=" " method="post" runat="server"> 
    <div id="menu">  
             
            <ul>
                <li><a href="">Inicio</a></li>
                <li><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Jugar</asp:LinkButton></li>
                <li><a href="">Carga</a></li>
                <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Subir</asp:LinkButton></li>
                <li class="der"><a href="">Salir</a></li>
            </ul> 
              
    </div>
  
    <div id="contener">
        <asp:TextBox ID="Tvista" runat="server" Visible="False" Height="239px" TextMode="MultiLine" Width="239px"></asp:TextBox>
            <asp:FileUpload ID="Bsubir" runat="server" Visible="False"/>
            <asp:Button ID="Bup" runat="server" Text="Cargar Archivo" Visible="False" OnClick="Bup_Click" />
        
    </div>
</form>

</body>
</html>
