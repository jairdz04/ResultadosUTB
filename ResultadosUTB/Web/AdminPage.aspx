<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ResultadosUTB.Web.OnlyLog.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administrador</title>


    <style>

        * {
        margin: 0;
        padding:0;
        
        }
        #equipo {
        height: 100%;
        width: 30%;
        background-color: #ccc;
        }

        #jugadores {
        height: 100%;
        width: 70%;
       margin-top: -20.5%;
        margin-left: 30%;
        background-color: #f61111;
        
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Out" />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="PanelContenedor" runat="server" Height="313px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Gestionar Equipo" OnClick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Gestionar Fecha" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Gestionar Resultado" OnClick="Button4_Click" />



            <br />



            <asp:Panel ID="PnlEquipo" runat="server" Height="279px">
           
                          <div id="equipo"> 
                  <br />
                 <br />
                                 &nbsp;
                              <asp:Label ID="Label2" runat="server" Text="Nombre del equipo"></asp:Label>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                              <br />
                              <br />
&nbsp;
                              <asp:Label ID="Label5" runat="server" Text="Nombre del delegado"></asp:Label>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                              <br />
                              <br />
                              &nbsp;
                              <asp:Label ID="Label6" runat="server" Text="E- Mail del delegado"></asp:Label>
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                              <br />
                 <br />
                               &nbsp;
                               <asp:Label ID="Label7" runat="server" Text="Telefono del delegado"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 <br />
                             
                           </div>


                <div id ="jugadores">

                     <asp:Label ID="Label8" runat="server" Text="Escriba los nombres de sus jugadores"></asp:Label>



                     <br />
                     <br />
                     &nbsp;
                     <asp:Label ID="Label9" runat="server" Text="1"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label10" runat="server" Text="6"></asp:Label>
                     &nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label11" runat="server" Text="11"></asp:Label>
                     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label24" runat="server" Text="16"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                     <br />
                     <br />
                     &nbsp;
                     <asp:Label ID="Label12" runat="server" Text="2"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label13" runat="server" Text="7"></asp:Label>
                     &nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label14" runat="server" Text="12"></asp:Label>
                     <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label27" runat="server" Text="17"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                     <br />
                     <br />
                     &nbsp;
                     <asp:Label ID="Label15" runat="server" Text="3"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label16" runat="server" Text="8"></asp:Label>
                     &nbsp;<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label17" runat="server" Text="13"></asp:Label>
                     <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label28" runat="server" Text="18"></asp:Label>
                     &nbsp;&nbsp;<asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                     <br />
                     <br />
&nbsp;&nbsp;<asp:Label ID="Label18" runat="server" Text="4"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label19" runat="server" Text="9"></asp:Label>
                     &nbsp;<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label20" runat="server" Text="14"></asp:Label>
                     <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label29" runat="server" Text="19"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                     <br />
                     <br />
                    &nbsp;
                     <asp:Label ID="Label21" runat="server" Text="5"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;<asp:Label ID="Label22" runat="server" Text="10"></asp:Label>
                     &nbsp;<asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label23" runat="server" Text="15"></asp:Label>
                     <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label30" runat="server" Text="20"></asp:Label>
                     &nbsp;
                     <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                     <br />
                     <br />
                    
                    



                </div>
                </asp:Panel>
            

                <asp:Panel ID="PnlFecha" runat="server" Height="279px">
                    <asp:Label ID="Label3" runat="server" Text="Hola2"></asp:Label>

               </asp:Panel>

                    <asp:Panel ID="PnlResultado" runat="server" Height="279px">
                        <asp:Label ID="Label4" runat="server" Text="Hola3"></asp:Label>

                    </asp:Panel>
                



        </asp:Panel>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
