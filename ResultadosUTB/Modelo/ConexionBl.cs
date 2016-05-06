using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ResultadosUTB.Modelo
{
    public class ConexionBl
    {
        public SqlConnection a;
        public SqlCommand sen;
        public SqlDataReader sl;

        public ConexionBl(){
            a = new SqlConnection("Server=JAIRDIAZ\\SQLEXPRESS; Database=ResultadosUTB; Integrated Security=true");
         }

        public SqlConnection getA
        {
            get {
                return a;
            }
        }
    }
}