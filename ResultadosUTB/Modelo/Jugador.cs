﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResultadosUTB.Modelo
{
    public class Jugador
    {
  #region "atributos"

        public string NombreJ;
        public string cod_Jug; 
        public string cod_equi;
        

  #endregion 

        #region "propiedades"

        public string nombre
        {
            get { return NombreJ; }
            set { NombreJ = value; }
        }

        public string Cod_jug {
            get { return cod_Jug; }
            set { cod_Jug = value; }
       
        }

        public string Cod_equi
        {
            get { return cod_equi; }
            set { cod_equi = value; }
        }

        

        #endregion

        #region "constructores"

        public Jugador() {
            this.NombreJ = "jair";
            this.cod_Jug = "T000";
            this.cod_equi = "01";
        

        
        }

        public Jugador(string NombreJ, string cod_Jug, string cod_equi) {
            this.NombreJ = NombreJ;
            this.cod_Jug = cod_Jug;
            this.cod_equi = cod_equi;
        
        
        }


        #endregion


        #region "metodos sobreescritos"

        public override string ToString()
        {
            return "Nombre: " + this.NombreJ +
            "\nCodigo : " + this.cod_Jug +
            "\nCodigo del equipo : " + this.cod_equi ;


        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Jugador o = (Jugador)obj;
            bool result = false;

            if ((this.NombreJ == o.NombreJ) &&
            (this.cod_Jug == o.cod_Jug) &&
            (this.cod_equi == o.cod_equi))

                result = true;

            return result;

        }


        #endregion 
    }
}