using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using ResultadosUTB.Modelo;


namespace ResultadosUTB.Web
{
    /// <summary>
    /// Descripción breve de ServicioClientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioClientes : System.Web.Services.WebService
    {

        [WebMethod]
        public Team [] ListadoEquipos()
        {
            SqlConnection con = new SqlConnection("server=JAIRDIAZ\\SQLEXPRESS; Database=ResultadosUTB; Integrated Security=true");
            con.Open();
            string sql = "SELECT codigo_equipo, nombre_equipo, tel_equipo,email_equipo FROM Equipos";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Team> lista = new List<Team>();
            while (reader.Read())
            {
                lista.Add(new Team(reader.GetString(1), reader.GetString(0), reader.GetString(3), reader.GetString(2)));
            }
            con.Close();

            return lista.ToArray();

        }
    }
}
