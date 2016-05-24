using System;
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
            Team t = new Team();

            t.Cod = TextBox2.Text;
            t.Nombre = TextBox1.Text;
            t.E_mail_Contact = TextBox3.Text;
            t.Tel_contact = TextBox4.Text;
            g.ActualizarEquipo(t);
            Response.Write("<script>alert('Actualizado correctamente');</script>");
                }catch(Exception ex){
                    Response.Write("<script>alert('Fallo al actualizar');</script>");
                
                }

        }

        protected void BtnGuardarFecha_Click(object sender, EventArgs e)
        {
            try {
                Calendario f = new Calendario();
                f.CodPartido = "1";//Label3.Text;
                f.CodEquipo1 = TextBox28.Text;
                f.CodEquipo2 = TextBox29.Text;
                f.CodFecha = DropDownList1.Text;
                f.Hora = TextBox59.Text;
                b.CrearProgramación(f);

           /*     Calendario f1 = new Calendario();
                f1.CodPartido = Label32.Text;
                f1.CodEquipo1 = TextBox22.Text;
                f1.CodEquipo2 = TextBox30.Text;
                f1.CodFecha = DropDownList1.Text;
                f1.Hora = TextBox60.Text;
                b.CrearProgramación(f1);

                Calendario f2 = new Calendario();
                f2.CodPartido = Label34.Text;
                f2.CodEquipo1 = TextBox31.Text;
                f2.CodEquipo2 = TextBox32.Text;
                f2.CodFecha = DropDownList1.Text;
                f2.Hora = TextBox61.Text;
                b.CrearProgramación(f2);

                Calendario f3 = new Calendario();
                f3.CodPartido = Label36.Text;
                f3.CodEquipo1 = TextBox33.Text;
                f3.CodEquipo2 = TextBox34.Text;
                f3.CodFecha = DropDownList1.Text;
                f3.Hora = TextBox62.Text;
                b.CrearProgramación(f3);

                Calendario f4 = new Calendario();
                f4.CodPartido = Label38.Text;
                f4.CodEquipo1 = TextBox35.Text;
                f4.CodEquipo2 = TextBox36.Text;
                f4.CodFecha = DropDownList1.Text;
                f4.Hora = TextBox63.Text;
                b.CrearProgramación(f4);

                Calendario f5 = new Calendario();
                f5.CodPartido = Label40.Text;
                f5.CodEquipo1 = TextBox37.Text;
                f5.CodEquipo2 = TextBox38.Text;
                f5.CodFecha = DropDownList1.Text;
                f5.Hora = TextBox64.Text;
                b.CrearProgramación(f5);

                Calendario f6 = new Calendario();
                f6.CodPartido = Label42.Text;
                f6.CodEquipo1 = TextBox39.Text;
                f6.CodEquipo2 = TextBox40.Text;
                f6.CodFecha = DropDownList1.Text;
                f6.Hora = TextBox65.Text;
                b.CrearProgramación(f6);

                Calendario f7 = new Calendario();
                f7.CodPartido = Label44.Text;
                f7.CodEquipo1 = TextBox41.Text;
                f7.CodEquipo2 = TextBox42.Text;
                f7.CodFecha = DropDownList1.Text;
                f7.Hora = TextBox66.Text;
                b.CrearProgramación(f7);
                */
            }catch(Exception ex){
            
           
            
            }

        }

        protected void BtnBuscarFecha_Click(object sender, EventArgs e)
        {
            string codigoFecha1 = DropDownList1.Text;
            string CodigoPartido1 = Label3.Text; 
            Calendario t = b.BuscarFecha(codigoFecha1, CodigoPartido1);

            if (b != null)
            {
                
            }
            else
            {
                Response.Write("<script>alert('No existe registro');</script>");

            }

        }




        }
       }
