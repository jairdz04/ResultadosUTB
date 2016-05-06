using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Datos
{
    public class CrudJugadores
    {

        ConexionBl c = new ConexionBl();

        private void ejecutar(String sql)
        {
            try
            {
                c.a.Open();
                c.sen = new SqlCommand(sql, c.a);
                c.sen.ExecuteNonQuery();
                c.a.Close();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void CrearJugador(Jugador j) {
            String insert = "insert into Jugador (NombreJ, CodigoJ, CodigoE) values ('" + j.NombreJ + "','" + j.cod_Jug + "','" + j.cod_equi +"')";
            ejecutar(insert);
        
        }

        public void EliminarJugador(string codigo)
        {
            String Borrar = "delete from Jugador where CodigoJ = '" + codigo + "'";
            ejecutar(Borrar);

        }

        /*public void ActualizarJugador(Jugador g)
        {
            String Actualizar = "update Jugador  set  NombreJ='" + g.NombreJ + "',CodigoJ = '" + g.cod_Jug + "', CodigoE = '" + g.cod_equi + "' , Programa = '" + g.programa +  "' where id_Cliente = '" + g.cod_Jug + "'";
            ejecutar(Actualizar);
        }*/


        public Jugador BuscarJugador(string Id)
        {
            Jugador j = new Jugador();

            String select = "select * from Jugador where CodigoJ = '" + Id + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                j = new Jugador();
                j.NombreJ = c.sl[0].ToString();
                j.cod_Jug = c.sl[1].ToString();
                j.cod_equi = c.sl[2].ToString();
         
            }
            c.a.Close();

            return j;

        }

    }
}