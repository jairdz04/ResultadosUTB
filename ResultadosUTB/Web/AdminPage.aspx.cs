﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;
using ResultadosUTB.Datos;

namespace ResultadosUTB.Web.OnlyLog
{
    public partial class AdminPage : System.Web.UI.Page
    {

        ConexionBl a = new ConexionBl();
        CrudGeneral g = new CrudGeneral();
        CrudJugadores h = new CrudJugadores();
        CrudCalendario b = new CrudCalendario();
        CrudResultados re = new CrudResultados();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                Label1.Text = "Sesión iniciada :  " + Session["UserID"].ToString();
            }
            else
            {
                //Label1.Text = "Fail";
               //Response.Write("<script>alert('Usted no ha iniciado sesión');</script>");
               Response.Redirect("Default.aspx");
            }

            PnlEquipo.Visible = true;
            PnlFecha.Visible = false;
            PnlResultado.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Session.RemoveAll();
            Response.Redirect("Default.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PnlEquipo.Visible = true;
            PnlFecha.Visible = false;
            PnlResultado.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PnlEquipo.Visible = false;
            PnlFecha.Visible = true;
            PnlResultado.Visible = false;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            PnlEquipo.Visible = false;
            PnlFecha.Visible = false;
            PnlResultado.Visible = true;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == ""))
                {
                    Response.Write("<script> alert ('Campos Vacios, favor completar'); </script>");
                }
                else { 
                Team t = new Team();
                t.Cod = TextBox2.Text;
                t.Nombre = TextBox1.Text;
                t.Tel_contact = TextBox4.Text;
                t.E_mail_Contact = TextBox3.Text;
                g.CrearEquipo(t);
                GuardarJugadores();
                Response.Write("<script>alert('Equipo creado con exito');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                }
            }
            catch (Exception ex) {
                Response.Write("<script>alert('Error');</script>");
            
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox27.Text == "")
            {
                Response.Write("<script>alert('campo vacio');</script>");

            }
            else
            {
                string codigo = TextBox27.Text;
                Team t = g.BuscarEquipo(codigo);

                if (g != null)
                {
                    TextBox1.Text = t.Nombre;
                    TextBox2.Text = t.Cod;
                    TextBox3.Text = t.E_mail_Contact;
                    TextBox4.Text = t.Tel_contact;
                }
                else
                {
                    Response.Write("<script>alert('No existe registro');</script>");

                }
            }

        }

        public void GuardarJugadores() {


            try
            {
                Jugador j1 = new Jugador();
                j1.NombreJ = TextBox5.Text;
                j1.cod_Jug =Label9.Text;
                j1.cod_equi= TextBox2.Text;
                h.CrearJugador(j1);

                Jugador j2 = new Jugador();
                j2.NombreJ = TextBox6.Text;
                j2.cod_Jug = Label10.Text;
                j2.cod_equi = TextBox2.Text;
                h.CrearJugador(j2);

                Jugador j3 = new Jugador();
                j3.NombreJ = TextBox7.Text;
                j3.cod_Jug = Label11.Text;
                j3.cod_equi = TextBox2.Text;
                h.CrearJugador(j3);

                
                Jugador j4 = new Jugador();
                j4.NombreJ = TextBox20.Text;
                j4.cod_Jug = Label24.Text;
                j4.cod_equi = TextBox2.Text;
                h.CrearJugador(j4);

                Jugador j5 = new Jugador();
                j5.NombreJ = TextBox8.Text;
                j5.cod_Jug = Label12.Text;
                j5.cod_equi = TextBox2.Text;
                h.CrearJugador(j5);

                Jugador j6 = new Jugador();
                j6.NombreJ = TextBox9.Text;
                j6.cod_Jug = Label13.Text;
                j6.cod_equi = TextBox2.Text;
                h.CrearJugador(j6);
                
                Jugador j7 = new Jugador();
                j7.NombreJ = TextBox10.Text;
                j7.cod_Jug = Label14.Text;
                j7.cod_equi = TextBox2.Text;
                h.CrearJugador(j7);

                Jugador j8 = new Jugador();
                j8.NombreJ = TextBox23.Text;
                j8.cod_Jug = Label27.Text;
                j8.cod_equi = TextBox2.Text;
                h.CrearJugador(j8);

                Jugador j9 = new Jugador();
                j9.NombreJ = TextBox11.Text;
                j9.cod_Jug = Label15.Text;
                j9.cod_equi = TextBox2.Text;
                h.CrearJugador(j9);


                Jugador j10 = new Jugador();
                j10.NombreJ = TextBox12.Text;
                j10.cod_Jug = Label16.Text;
                j10.cod_equi = TextBox2.Text;
                h.CrearJugador(j10);

                Jugador j11 = new Jugador();
                j11.NombreJ = TextBox13.Text;
                j11.cod_Jug = Label17.Text;
                j11.cod_equi = TextBox2.Text;
                h.CrearJugador(j11);

                Jugador j12 = new Jugador();
                j12.NombreJ = TextBox24.Text;
                j12.cod_Jug = Label28.Text;
                j12.cod_equi = TextBox2.Text;
                h.CrearJugador(j12);
                
                Jugador j13 = new Jugador();
                j13.NombreJ = TextBox14.Text;
                j13.cod_Jug = Label18.Text;
                j13.cod_equi = TextBox2.Text;
                h.CrearJugador(j13);

                Jugador j14 = new Jugador();
                j14.NombreJ = TextBox15.Text;
                j14.cod_Jug = Label19.Text;
                j14.cod_equi = TextBox2.Text;
                h.CrearJugador(j14);

                Jugador j15 = new Jugador();
                j15.NombreJ = TextBox16.Text;
                j15.cod_Jug = Label20.Text;
                j15.cod_equi = TextBox2.Text;
                h.CrearJugador(j15);
                
                Jugador j16 = new Jugador();
                j16.NombreJ = TextBox25.Text;
                j16.cod_Jug = Label29.Text;
                j16.cod_equi = TextBox2.Text;
                h.CrearJugador(j16);
                //por aquí
                Jugador j17 = new Jugador();
                j17.NombreJ = TextBox17.Text;
                j17.cod_Jug = Label21.Text;
                j17.cod_equi = TextBox2.Text;
                h.CrearJugador(j17);

                Jugador j18 = new Jugador();
                j18.NombreJ = TextBox18.Text;
                j18.cod_Jug = Label22.Text;
                j18.cod_equi = TextBox2.Text;
                h.CrearJugador(j18);

                Jugador j19 = new Jugador();
                j19.NombreJ = TextBox19.Text;
                j19.cod_Jug = Label23.Text;
                j19.cod_equi = TextBox2.Text;
                h.CrearJugador(j19);

                Jugador j20 = new Jugador();
                j20.NombreJ = TextBox26.Text;
                j20.cod_Jug = Label30.Text;
                j20.cod_equi = TextBox2.Text;
                h.CrearJugador(j20);


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");

            }
        
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try {
                if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == ""))
                {
                    Response.Write("<script>alert('Campos vacios');</script>");
                }
                else {
                    Team t = new Team();

                    t.Cod = TextBox2.Text;
                    t.Nombre = TextBox1.Text;
                    t.E_mail_Contact = TextBox3.Text;
                    t.Tel_contact = TextBox4.Text;
                    g.ActualizarEquipo(t);
                    Response.Write("<script>alert('Actualizado correctamente');</script>");
                
                }
                }catch(Exception ex){
                    Response.Write("<script>alert('Fallo al actualizar');</script>");
                
                }

        }

        protected void BtnGuardarFecha_Click(object sender, EventArgs e)
        {

            try {
                if ((TextBox76.Text == "") || (TextBox77.Text == "") || (TextBox78.Text == "") || (TextBox79.Text == "") || (TextBox80.Text == "")) {
                    Response.Write("<script> alert ('Campos Vacios, Por favor completar campos');</script>");
                
                } else {
                    Calendario f = new Calendario();
                    string CodPartido = TextBox76.Text;
                    Calendario t = b.BuscarCod (CodPartido);
                    if (b == null)
                    {
                        Response.Write("<script> alert (' El codigo de partido ya existe');</script>");
                    }
                    else {
                        f.CodPartido = TextBox76.Text;
                        f.CodEquipo1 = TextBox77.Text;
                        f.CodEquipo2 = TextBox78.Text;
                        f.CodFecha = TextBox79.Text;
                        f.Hora = TextBox80.Text;
                        b.CrearProgramación(f);

                        Response.Write("<script> alert (' Registro guardado');</script>");
                        TextBox76.Text = "";
                        TextBox77.Text = "";
                        TextBox78.Text = "";
                        TextBox79.Text = "";
                        TextBox80.Text = "";
                        PnlFecha.Visible = true;
                        PnlEquipo.Visible = false;
                        PnlResultado.Visible = false;
                    }
                   
                }
            
            
            }catch(Exception ex){
                Response.Write("<script> alert ('Error al guardar');</script>");
            
            }

        }

        protected void BtnBuscarFecha_Click(object sender, EventArgs e)
        {

           
            string CodigoPartido1 = TextBox76.Text; 
            Calendario t = b.BuscarFecha(CodigoPartido1);

            if (b != null)
            {

                TextBox76.Text = t.CodPartido;
                TextBox77.Text = t.CodEquipo1;
                TextBox78.Text = t.CodEquipo2;
                TextBox79.Text = t.CodFecha;
                TextBox80.Text = t.Hora;
                PnlFecha.Visible = true;
                PnlEquipo.Visible = false;
                PnlResultado.Visible = false;
              
                
            }
            else
            {
                Response.Write("<script>alert('No existe registro');</script>");

            }
        

        }

        protected void BtnEditarFecha_Click(object sender, EventArgs e)
        {
           /* Calendario t = new Calendario();
             t.CodPartido = TextBox76.Text;
              t.CodEquipo1 = TextBox77.Text;
              t.CodEquipo2 = TextBox78.Text;
              t.CodFecha = TextBox79.Text;
             t.Hora=  TextBox80.Text;
             b.ActualizarCalendario(t);*/

             try {
                if ((TextBox76.Text == "") || (TextBox77.Text == "") || (TextBox78.Text == "") || (TextBox79.Text == "") || (TextBox80.Text == "")) {
                    Response.Write("<script> alert ('Campos Vacios');</script>");
                
                } else {
                    Calendario t = new Calendario();  
                          t.CodPartido = TextBox76.Text;
                          t.CodEquipo1 = TextBox77.Text;
                          t.CodEquipo2 = TextBox78.Text;
                          t.CodFecha = TextBox79.Text;
                          t.Hora=  TextBox80.Text;
                            b.ActualizarCalendario(t);
                          TextBox76.Text = "";
                          TextBox77.Text = "";
                          TextBox78.Text = "";
                          TextBox79.Text = "";
                          TextBox80.Text = "";
                          PnlFecha.Visible = true;
                          PnlEquipo.Visible = false;
                          PnlResultado.Visible = false;

                        Response.Write("<script> alert (' Actualizado correctamente');</script>");
    
                }
            
            
            }catch(Exception ex){
                Response.Write("<script> alert ('Error al Actualizar');</script>");
            
            }

        }

        protected void BtnGuardarResultados_Click(object sender, EventArgs e)
        {
            try {

                 if ((TextBox75.Text == "") || (TextBox67.Text == "") || (TextBox71.Text == "") || (TextBox68.Text == "") || (TextBox72.Text == "")|| (TextBox70.Text == "")||
                 (TextBox74.Text == "")|| (TextBox69.Text == "") || (TextBox73.Text == "")) {
                    Response.Write("<script> alert ('Campos Vacios, Por favor completar campos');</script>");
                
                } else {
                   Resultados r = new Resultados();
                    string CodPartido = TextBox76.Text;
                    Calendario t = b.BuscarCod (CodPartido);
                    if (b == null)
                    {
                        Response.Write("<script> alert (' El Resultado de partido ya existe');</script>");
                    }
                    else {
                        
                r.numero_partido = Convert.ToInt32(TextBox75.Text);
                r.goles_equipo1 = Convert.ToInt32(TextBox67.Text);
                r.goles_equipo2 = Convert.ToInt32(TextBox71.Text);
                r.amarillas_equipo1 = Convert.ToInt32(TextBox68.Text);
                r.amarillas_equipo2 = Convert.ToInt32(TextBox72.Text);
                r.rojas_equipo1 = Convert.ToInt32(TextBox70.Text);
                r.rojas_equipo2 = Convert.ToInt32(TextBox74.Text);
                r.azules_equipo1 = Convert.ToInt32(TextBox69.Text);
                r.azules_equipo2 = Convert.ToInt32(TextBox73.Text);
                re.CrearResultado(r);

                        Response.Write("<script> alert (' Registro guardado');</script>");
                         TextBox75.Text = "";
                         TextBox67.Text = "";  
                         TextBox71.Text = "";
                         TextBox68.Text = ""; 
                         TextBox72.Text = ""; 
                         TextBox70.Text = "";
                         TextBox74.Text = "";
                         TextBox69.Text = "";
                         TextBox73.Text = "";
                        PnlFecha.Visible = false;
                        PnlEquipo.Visible = false;
                        PnlResultado.Visible = true;
                    }
                   
                }
               
            
            }
            catch (Exception ex) {
                Response.Write("<script> alert (' El Resultado de partido ya existe');</script>");
            }
            
        }

        protected void BtnBuscarPartido_Click(object sender, EventArgs e)
        {

            string CodigoPartido1 = TextBox75.Text;
            Resultados t = re.BuscarResultado(CodigoPartido1);

            if (b != null)
            {
                int a = Convert.ToInt32(t.numero_partido);
                int d = Convert.ToInt32(t.amarillas_equipo1);
                int f = Convert.ToInt32(t.amarillas_equipo2);
                int g = Convert.ToInt32(t.azules_equipo1);
                int h = Convert.ToInt32(t.azules_equipo2);
                int i = Convert.ToInt32(t.goles_equipo1);
                int j = Convert.ToInt32(t.goles_equipo2);
                int k = Convert.ToInt32(t.rojas_equipo1);
                int l = Convert.ToInt32(t.rojas_equipo2);
                TextBox75.Text = "" + a;
                TextBox67.Text = "" + i;
                TextBox71.Text = "" + j;
                TextBox68.Text = "" + d;
                TextBox72.Text = "" + f;
                TextBox70.Text = "" + k;
                TextBox74.Text = "" + l;
                TextBox69.Text = "" + g;
                TextBox73.Text = "" + h;
                
                PnlFecha.Visible = false;
                PnlEquipo.Visible = false;
                PnlResultado.Visible = true;


            }
            else
            {
                Response.Write("<script>alert('No existe registro');</script>");

            }

        }
        }




        }
       

