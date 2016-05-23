using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Datos
{
    public class CrudGeneral
    {
        ConexionBl c = new ConexionBl();

        private void ejecutar(string sql) {
           try
            {
                c.a.Open();
                c.sen = new SqlCommand(sql, c.a);
                c.sen.ExecuteNonQuery();
                c.a.Close();
            }catch (Exception ex){
            
            }
        }

        public void CrearEquipo(Team t) { 
        String insert = "insert into Equipos (codigo_equipo, nombre_equipo, tel_equipo, email_equipo) values ('" + t.Cod + "','" + t.Nombre + "','" + t.Tel_contact + "','" + t.E_mail_Contact +"')";
            ejecutar(insert);
        
        }
       /* public void CrearJugador(Jugador j)
        {
            String insert = "insert into Jugadores (Codigo_jugador, nombre_jugador, codigo_equipo) values ('" + j.cod_Jug + "','" + j.NombreJ + "','" + j.cod_equi + "')";
            ejecutar(insert);

        }*/

        public Team BuscarEquipo(string id) {
            Team t = new Team();

            String select = "select * from Equipos where codigo_equipo = '" + id + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                t = new Team();
                t.Cod = c.sl[1].ToString();
                t.Nombre = c.sl[2].ToString();
                t.E_mail_Contact = c.sl[4].ToString();
                t.Tel_contact = c.sl[3].ToString();

            }
            c.a.Close();

            return t;


         }


        public void ActualizarEquipo(Team t)
        {
            String Actualizar = "update Equipos  set  nombre_equipo='" + t.Nombre + "',codigo_equipo = '" + t.Cod + "', tel_equipo = '" + t.Tel_contact + "' , email_equipo = '" + t.E_mail_Contact + "' where codigo_equipo= '" + t.Cod + "'";
            ejecutar(Actualizar);
        }







    }
}