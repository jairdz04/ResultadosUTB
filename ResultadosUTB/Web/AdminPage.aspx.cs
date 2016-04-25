using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Web.OnlyLog
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                Label1.Text = "Sesión iniciada :  " + Session["UserID"].ToString();
            }
            else
            {
                //Label1.Text = "Fail";
               // Response.Write("<script>alert('Usted no ha iniciado sesión');</script>");
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
    }
}