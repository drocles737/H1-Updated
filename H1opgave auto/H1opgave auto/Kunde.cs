using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace H1opgave_auto
{
    class Kunde
    {
        private int KundeID;
        private string Fnavn;
        private string Enavn;
        private string Email;
        private string Adresse;
        private int Postnr;
        private string By;
        private int Tlfnr;

        public int mykundeid
        {
            get { return KundeID; }
            set { KundeID = value; }
        }

        public string myfnavn
        {
            get { return Fnavn;}
            set { Fnavn = value; }
        }

        public string myenavn
        {
            get { return Enavn; }
            set { Enavn = value; }
        }

        public string myemail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string myadress
        {
            get { return Adresse; }
            set { Adresse = value; }
        }

        public int mypostnr
        {
            get { return Postnr; }
            set { Postnr = value; }
        }

        public string myby
        {
            get { return By; }
            set { By = value; }
        }

        public int mytlfnr
        {
            get { return Tlfnr; }
            set { Tlfnr = value; }
        }

        public Kunde()
        {

        }

        public Kunde(int kundeid, string fnavn, string enavn, string email, string adress, int postnr, string by, int tlfnr)
        {
            KundeID = kundeid;
            Fnavn = fnavn;
            Enavn = enavn;
            Email = email;
            Adresse = adress;
            Postnr = postnr;
            By = by;
            Tlfnr = tlfnr;
        }

        
    }
}
