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
                Response.Write("<script>alert('Eso está malo');</script>");

            }

        }

      /*  protected void BtnBuscar_Click(object sender, EventArgs e)
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
                Response.Write("<script>alert('Eso está malo');</script>");

            }
        }*/

        

        

        

       



    }
}