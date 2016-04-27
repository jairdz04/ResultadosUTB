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

public team (string Nombre, string Cod , string Name_Contact, string E_mail_contact, string Tel_contact){
    
     This.Nombre = Nombre;
            This.Cod = Cod ;
             This.Name_Contact = Name_Contact;
        This.E_mail_Contact = E_mail_Contact ;
       This.Tel_contact = Tel_contact;
    
}

        #endregion
        
        #region "Métodos SobreEscritos"
        
        public override string ToString(){
            return "Nombre: " + This.Nombre +
            "\nCodigo : " + This.Cod +
            "\nNombre de contacto : " + This.Name_Contact +
            "\nE Mail de contacto : " + This.E_mail_Contact +
            "\nTelefono de contacto : " + This.Tec_contact ;
            
            
        }
        
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public override bool Equals (object obj){
           Team o = (Team)obj;
            bool result = false;
            
            if ((this.Name == o.Nombre)&& 
            (this.Cod == o.Cod) &&
            (this.Name_Contact == o.Name_Contact) &&
            (this.E_mail_Contact == o.E_mail_Contact) &&
            (this.Tec_contact == o.Tec_contact))
            
            result= true;
            
            return result;
            
        }
  
        #endregion 

    }
}
