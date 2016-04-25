using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ResultadosUTB.Web
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] != null)
            {
               // Label1.Text = "Sesión iniciada :  " + Session["UserID"].ToString();
                Response.Write("<script>alert('Por cuestiones de seguridad, usted debio ingresar un codigo para acceder a esta pagina.');</script>");

            }
            else
            {
                
              // Response.Write("<script>alert('Usted no ha iniciado sesión');</script>");
               // Response.Redirect("Default.aspx");
            }

        }
    }
}