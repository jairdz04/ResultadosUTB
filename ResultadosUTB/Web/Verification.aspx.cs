using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Web
{
    public partial class Verification : System.Web.UI.Page
    {

        ConexionBl a = new ConexionBl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //  a.getA.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Usuarios Where ds_login '" + TextBox1.Text , a.getA);
            //DataTable dt = new DataTable();
            /*sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                 Session["UserID"] = TextBox1.Text;
                Response.Redirect("SignUp.aspx");

            }
            else
            {
               
                Response.Write("<script>alert('codigo erroneo');</script>");
                
            }

            a.getA.Close();
        }*/
            Response.Redirect("SignUp.aspx");
        
        }


        }
    }


