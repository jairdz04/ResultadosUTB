using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResultadosUTB.Modelo
{
    public class Team
    {

        #region "Atributos"

        public string Nombre;
        public string Cod;
        public string Name_Contact;
        public string E_mail_Contact;
        public string Tel_contact;


        #endregion 

        #region "propiedades"

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        public string cod
        {
            get { return Cod; }
            set { Cod = value; }
        }
        public string name_contact
        {
            get { return Name_Contact; }
            set { Name_Contact = value; }
        }


        public string mail_contact
        {
            get { return E_mail_Contact; }
            set { E_mail_Contact= value; }
        }

         public string tel_contact
        {
            get { return Tel_contact; }
            set { Tel_contact = value; }
        }


        #endregion


        #region "constructores"
        
        public Team () {
            This.Nombre = "Jair";
            This.Cod = "123";
             This.Name_Contact = "Jose Joaquin";
        This.E_mail_Contact = "Jairdz040";
       This.Tel_contact = "000000";
        }

      /*  public Persona() {
            this.id = "";
            this.TipoID = "";
            this.identificacion = "";
            this.Nombres = "";
            this.Apellidos = "";
            this.sede = "";
            this.Sexo = "";
            this.F_Nacimiento = "";
        }

        public Persona(string id, string TipoID, string identificacion, string Nombres, string Apellidos,string sede, string Sexo, string F_Nacimiento) {

            this.id = id;
            this.TipoID = TipoID;
            this.identificacion = identificacion;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.sede = sede;
            this.Sexo = Sexo;
            this.F_Nacimiento = F_Nacimiento;
        
        }
        */
        #endregion

    }
}
