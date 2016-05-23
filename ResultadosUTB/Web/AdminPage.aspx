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
        
    <div id ="contenedor">
    
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
           



            <br />



            <asp:Panel ID="PnlEquipo" runat="server" Height="279px">
           
                 &nbsp;<br /> &nbsp;&nbsp;
                 <asp:Label ID="Label31" runat="server" Text="Ingrese código de equipo"></asp:Label>
                 &nbsp;&nbsp;<asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                 &nbsp; &nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Buscar" />
                          <br />
                          <br />
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
                     <asp:Label ID="Label5" runat="server" Text="código del equipo"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                     <br />
                     &nbsp;
                 </div>
                 <div id="jugadores">
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
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnEditar" runat="server" Text="Editar" OnClick="BtnEditar_Click" />    
            </asp:Panel>
            

                <asp:Panel ID="PnlFecha" runat="server" Height="279px">
                    Gestión de Programación<br />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; # de Fecha&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem Value="cuartos">8</asp:ListItem>
                        <asp:ListItem Value="semifinal">9</asp:ListItem>
                        <asp:ListItem Value="Final">10</asp:ListItem>
                    </asp:DropDownList>

                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label63" runat="server" Text="Fecha y hora"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                     <asp:Label ID="Label3" runat="server" Text="1."></asp:Label>

                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label26" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox59" runat="server"></asp:TextBox>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label32" runat="server" Text="2."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Label ID="Label33" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox60" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnGuardarFecha" runat="server" OnClick="BtnGuardarFecha_Click" Text="Guardar" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:Label ID="Label34" runat="server" Text="3."></asp:Label>

                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label35" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox61" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label36" runat="server" Text="4."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;<asp:Label ID="Label37" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox62" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnEditarFecha" runat="server" Text="Editar" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label38" runat="server" Text="5."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Label ID="Label39" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox63" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label40" runat="server" Text="6."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label41" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnBuscarFecha" runat="server" OnClick="BtnBuscarFecha_Click" Text="Buscar" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label42" runat="server" Text="7."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label43" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox65" runat="server"></asp:TextBox>

                    <br />

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label44" runat="server" Text="8."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label45" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>


                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox66" runat="server"></asp:TextBox>


               </asp:Panel>

                    <asp:Panel ID="PnlResultado" runat="server" Height="279px">
                        <asp:Label ID="Label4" runat="server" Text="Gestión de resultados"></asp:Label>
                        
                         <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label62" runat="server" Text="# de fecha"></asp:Label>
&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>Cuartos1</asp:ListItem>
                            <asp:ListItem>cuartos2</asp:ListItem>
                            <asp:ListItem>cuartos3</asp:ListItem>
                            <asp:ListItem>cuartos4</asp:ListItem>
                            <asp:ListItem>Semifinal1</asp:ListItem>
                            <asp:ListItem>semifinal2</asp:ListItem>
                            <asp:ListItem>Final</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label46" runat="server" Text="1."></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label47" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox>

                        <br />

                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label48" runat="server" Text="2."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Label ID="Label49" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox>

                        <br />

                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <asp:Label ID="Label50" runat="server" Text="3."></asp:Label>

                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox47" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label51" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox48" runat="server"></asp:TextBox>

                        <br />

                    <br />

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label52" runat="server" Text="4."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox49" runat="server"></asp:TextBox>

                    &nbsp;&nbsp;<asp:Label ID="Label53" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox50" runat="server"></asp:TextBox>
                        <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label54" runat="server" Text="5."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox51" runat="server"></asp:TextBox>
                    &nbsp;
                    <asp:Label ID="Label55" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox52" runat="server"></asp:TextBox>

                        <br />

                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label56" runat="server" Text="6."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox53" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label57" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox54" runat="server"></asp:TextBox>

                        <br />

                    &nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label58" runat="server" Text="7."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox55" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label59" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox56" runat="server"></asp:TextBox>

                        <br />

                    <br />

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label60" runat="server" Text="8."></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label61" runat="server" Text="VS"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox58" runat="server"></asp:TextBox>

                    </asp:Panel>
                



        </asp:Panel>
        <br />
        <br />
    </div>
    </form>
</body>
</html>
