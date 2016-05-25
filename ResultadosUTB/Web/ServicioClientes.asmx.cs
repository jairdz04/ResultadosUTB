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

        [WebMethod]
        public Jugador[] ListadoJugadores() {

            SqlConnection con = new SqlConnection("server=JAIRDIAZ\\SQLEXPRESS; Database=ResultadosUTB; Integrated Security=true");
            con.Open();
            string sql = "SELECT Codigo_jugador, nombre_jugador , codigo_equipo FROM Jugadores";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Jugador> lista = new List<Jugador>();
            while (reader.Read())
            {
                lista.Add(new Jugador(reader.GetString(1), reader.GetString(0), reader.GetString(2)));
            }
            con.Close();

            return lista.ToArray();
        
        }

        [WebMethod]
        public Calendario[] ListadoCalendario() {

            SqlConnection con = new SqlConnection("server=JAIRDIAZ\\SQLEXPRESS; Database=ResultadosUTB; Integrated Security=true");
            con.Open();
            string sql = "SELECT numero_partido, codigo_equipo1, codigo_equipo2, codigo_fecha, fecha_encuentro FROM calendario";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Calendario> lista = new List<Calendario>();
            while (reader.Read())
            {
                lista.Add(new Calendario(Convert.ToString(reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), Convert.ToString(reader.GetDateTime(4))));
            }
            con.Close();

            return lista.ToArray();
        
        
        
        }


        [WebMethod]

        public Resultados[] ListadoResultados() {
            SqlConnection con = new SqlConnection("server=JAIRDIAZ\\SQLEXPRESS; Database=ResultadosUTB; Integrated Security=true");
            con.Open();
            string sql = "SELECT numero_partido , goles_equipo1, goles_equipo2, amarillas_equipo1, amarillas_equipo2, rojas_equipo1, rojas_equipo2, azules_equipo1, azules_equipo2 FROM partidos";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Resultados> lista = new List<Resultados>();
            while (reader.Read()) {
                lista.Add(new Resultados(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
            
            }
            con.Close();

            return lista.ToArray();
        
        }


    }
}
