<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ResultadosUTB.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SIGN IN</title>

    <link href="StyleDefault.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
    <asp:Image ID="Image1" runat="server" Height="115px" ImageUrl="~/imagenes/utb.png" Width="546px" />
     
    <form id="form1" runat="server">
       
       
    <div  id="Contenedor">
    
        
 
   <div id="user">
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox1" runat="server" Height="15px" Width="120px"></asp:TextBox>
   </div>
        
                                                                       <br />
        
        <div id="pass">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"  Height="15px" Width="120px" ></asp:TextBox>

   &nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Login" Height="31px" Width="83px" OnClick="Button1_Click"  />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Registrarme" Height="31px" Width="83px" OnClick="Button2_Click"  />

   </div>

 
        

    </div>
        
    </form>
    <p>
&nbsp;
    </p>
</body>
</html>
