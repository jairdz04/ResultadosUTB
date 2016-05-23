using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ResultadosUTB.Modelo;

namespace ResultadosUTB.Web
{
    public partial class Default : System.Web.UI.Page
    {

        ConexionBl a = new ConexionBl();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label3.Visible = false;
            //response.write("<script> alert('Error');</script>");
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            a.getA.Open();

            
            
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Usuarios Where ds_login = '" + TextBox1.Text + "'and ds_Password='" + TextBox2.Text + "'", a.getA);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                Session["UserID"] = TextBox1.Text;
                Response.Redirect("AdminPage.aspx");

            }
            else
            {
               //Datos erroneos... Insertar Label ("-PENDIENTE-")
                //Label3.Visible = True;
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();
            }

            a.getA.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Verification.aspx");
        }


         

    }
}
