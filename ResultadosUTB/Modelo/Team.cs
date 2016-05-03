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
            this.Nombre = "Jair";
            this.Cod = "123";
        this.E_mail_Contact = "Jairdz040";
       this.Tel_contact = "000000";
        }

public Team (string Nombre, string Cod , string E_mail_Contact, string Tel_contact){
    
     this.Nombre = Nombre;
            this.Cod = Cod ;
        this.E_mail_Contact = E_mail_Contact ;
       this.Tel_contact = Tel_contact;
    
}

        #endregion
        
        #region "Métodos SobreEscritos"
        
        public override string ToString(){
            return "Nombre: " + this.Nombre +
            "\nCodigo : " + this.Cod +
            "\nE Mail de contacto : " + this.E_mail_Contact +
            "\nTelefono de contacto : " + this.Tel_contact ;
            
            
        }
        
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public override bool Equals (object obj){
           Team o = (Team)obj;
            bool result = false;
            
            if ((this.Nombre == o.Nombre)&& 
            (this.Cod == o.Cod) &&
            (this.E_mail_Contact == o.E_mail_Contact) &&
            (this.Tel_contact == o.Tel_contact))
            
            result= true;
            
            return result;
            
        }
  
        #endregion

    }
}
