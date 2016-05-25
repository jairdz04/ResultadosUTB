using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResultadosUTB.Modelo
{
    public class Resultados
    {

        #region "atributos"

        public int numero_partido;
        public int goles_equipo1;
        public int goles_equipo2;
        public int amarillas_equipo1;
        public int amarillas_equipo2;
        public int rojas_equipo1;
        public int rojas_equipo2;
        public int azules_equipo1;
        public int azules_equipo2;
        private int p1;
        private int p2;
        private int p3;
        private int p4;
        private int p5;
        private int p6;
        private int p7;
        private int p8;
        private int p9;

        
        #endregion

        public int NumeroPartido
        {
            get { return numero_partido; }
            set { numero_partido = value; }
        }

        public int Goles_equipo1
        {
            get { return goles_equipo1; }
            set { goles_equipo1 = value; }
        }

        public int Goles_equipo2
        {
            get { return goles_equipo2; }
            set { goles_equipo2 = value; }
        }

        public int Amarillas_equipo1
        {
            get { return amarillas_equipo1; }
            set { amarillas_equipo1 = value; }
        }

        public int Amarillas_equipo2
        {
            get { return amarillas_equipo2; }
            set { amarillas_equipo2 = value; }
        }

        public int Rojas_equipo1
        {
            get { return rojas_equipo1; }
            set { rojas_equipo1 = value; }
        }

        public int Rojas_equipo2
        {
            get { return rojas_equipo2; }
            set { rojas_equipo2 = value; }
        }

        public int Azules_equipo1
        {
            get { return azules_equipo1; }
            set { azules_equipo1 = value; }
        }

        public int Azules_equipo2
        {
            get { return azules_equipo2; }
            set { azules_equipo2 = value; }
        }
        public Resultados() {
            this.numero_partido = 0 ;
            this.goles_equipo1 = 0;
            this.goles_equipo2 = 0;
            this.amarillas_equipo1 = 0;
            this.amarillas_equipo2 = 0;
            this.rojas_equipo1 = 0;
            this.rojas_equipo2 = 0;
            this.azules_equipo1 = 0;
            this.azules_equipo2 = 0;
        

        
        }

        public Resultados(int numero_partido, int goles_equipo1, int goles_equipo2, int amarillas_equipo1, int amarillas_equipo2, int rojas_equipo1, int rojas_equipo2, int azules_equipo1, int azules_equipo2)
        {
           
            this.numero_partido = numero_partido;
            this.goles_equipo1 =goles_equipo1;
            this.goles_equipo2 = goles_equipo2;
            this.amarillas_equipo1 = amarillas_equipo1;
            this.amarillas_equipo2 = amarillas_equipo2;
            this.rojas_equipo1 = rojas_equipo1;
            this.rojas_equipo2 = rojas_equipo2;
            this.azules_equipo1 = azules_equipo1;
            this.azules_equipo2 = azules_equipo2;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        /*public override string ToString()
        {
            return "Nombre: " + this.NombreJ +
            "\nCodigo : " + this.cod_Jug +
            "\nCodigo del equipo : " + this.cod_equi;


        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Resultados o = (Resultados)obj;
            bool result = false;

            if ((this.NombreJ == o.NombreJ) &&
            (this.cod_Jug == o.cod_Jug) &&
            (this.cod_equi == o.cod_equi))

                result = true;

            return result;

        }*/


    }
}