﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResultadosUTB.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Datos
{
    public class CrudCalendario
    {
        ConexionBl c = new ConexionBl();

        private void ejecutar(string sql)
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

            }
        }

        public void CrearProgramación(Calendario t)
        {
            String insert = "insert into calendario (numero_partido,codigo_equipo1,codigo_equipo2,codigo_fecha,fecha_encuentro) values ('" + t.CodPartido + "','" + t.CodEquipo1 + "','" + t.CodEquipo2 + "','" + t.CodFecha + "','" + t.Hora + "')";
            ejecutar(insert);

        }



        public Calendario BuscarFecha( string CodigoPartido) {
            Calendario t = new Calendario();

            String select = "select * from calendario where  numero_partido = '" + CodigoPartido +"'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                t = new Calendario();
                t.CodPartido =c.sl[1].ToString();
                t.CodEquipo1 = c.sl[2].ToString();
                t.CodEquipo2 = c.sl[3].ToString();
                t.codFecha = c.sl[4].ToString();
                t.Hora = c.sl[5].ToString();
            }
            c.a.Close();

            return t;


         }

        public Calendario BuscarCod(string cod) {
            Calendario t = new Calendario();
            String select = "select numero_partido from calendario where  numero_partido = '" + cod + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                t = new Calendario();
                t.CodPartido = c.sl[1].ToString();
              
            }
            c.a.Close();

            return t;

        
        }

        public void ActualizarCalendario(Calendario t)
        {
            String Actualizar = "update calendario  set  codigo_equipo1='" + t.CodEquipo1 + "',codigo_equipo2 = '" + t.CodEquipo2 + "', codigo_fecha = '" + t.CodFecha + "' , fecha_encuentro = '" + t.Hora + "' where numero_partido= '" + t.CodPartido + "'";
            ejecutar(Actualizar);
        }

    }
}