using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResultadosUTB.Modelo
{
    public class Calendario
    {

        #region "atributos"
        public string CodPartido;
        public string CodEquipo1;
        public string CodEquipo2;
        public string CodFecha;
        public string Hora;

#endregion

        #region "propriedades"

        public string codPartido
        {
            get { return CodPartido; }
            set { CodPartido = value; }
        
        }

        public string codEquipo1 {
            get { return CodEquipo1; }
            set { CodEquipo1 = value; }
        
        }

        public string codEquipo2
        {
            get { return CodEquipo2; }
            set { CodEquipo2 = value; }

        }

        public string codFecha {
            get { return CodFecha; }
            set { CodFecha = value; }
        }

        public string hora {
            get { return Hora; }
            set { Hora = value; }
        }
        
        
        #endregion

        #region "constructores"

        public Calendario() {
            this.CodPartido= "000";
            this.CodEquipo1 = "Equipo1";
            this.CodEquipo2 = "Equipo2";
            this.CodFecha = "Fecha";
            this.Hora = "Hora";
        
        }

        public Calendario(string CodPartido, string CodEquipo1, string CodEquipo2, string CodFecha, string Hora)
        {
            this.CodPartido = CodPartido;
            this.CodEquipo1 = CodEquipo1;
            this.CodEquipo2 = CodEquipo2;
            this.CodFecha = CodFecha;
            this.Hora = Hora;

        
        }

        #endregion

        #region "metodos sobreescritos"

        public override string ToString()
        {
            return "Codigo Partido: " + this.CodPartido +
           "\nCodigo Equipo1: " + this.CodEquipo1 +
           "\nCodigo Equipo2 : " + this.CodEquipo2 +
           "\nNumero de fecha: " + this.CodFecha +
           "\nHora del Partido : " + this.Hora ;
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Calendario c = (Calendario)obj;
            bool result = false;

            if ((this.CodPartido == c.CodPartido) &&
            (this.CodEquipo1 == c.CodEquipo1) &&
            (this.CodEquipo2 == c.CodEquipo2)&&
                (this.CodFecha == c.CodFecha)&&
                (this.Hora == c.Hora))

                result = true;

            return result;

        }


        #endregion

    }
}