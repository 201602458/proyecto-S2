<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="fase1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <LINK REL=StyleSheet HREF="css/estilo.css" TYPE="text/css" MEDIA=screen>
<body>

    <div id="titulo">
        Inicio De Sesion
    </div>
    <form action="" method="post" >
        
        <label for="fname">Usuario</label><br>
        <input type="text" id="fname"  value=""><br>

        <label for="fname">Contraseña</label><br>
        <input type="password" id="fname"  value=""><br>
		
        <br>	
		<input type="submit" id="bname" name=" Boton" value="Aceptar">
        <br>	
        <br>	
	
		<a href="registro.aspx" id="linkR">Crea un nuevo usuario aqui!!</a>
    </form>
   
</body>
</html>
