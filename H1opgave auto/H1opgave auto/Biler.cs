using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace H1opgave_auto
{
    class Biler
    {
        private string Regnr;
        private string Mærke;
        private string Model;
        private int Årgang;
        private int Km;
        private string Brændstoftype;

        public string myregnr
        {
            get { return Regnr; }
            set { Regnr = value; }
        }

        public string mymærke
        {
            get { return Mærke; }
            set { Mærke = value; }
        }

        public string mymodel
        {
            get { return Model; }
            set { Model = value; }
        }

        public int myårgang
        {
            get { return Årgang; }
            set { Årgang = value; }
        }

        public int mykm
        {
            get { return Km; }
            set { Km = value; }
        }

        public string mybrændstof
        {
            get { return Brændstoftype; }
            set { Brændstoftype = value; }
        }

        public Biler()
        {

        }
        
        public Biler(string mitregnr, string mitmærke, string mitmodel, int mitårgang, int mitkm, string mitbrændstof)
        {
            Regnr = mitregnr;
            Mærke = mitmærke;
            Model = mitmodel;
            Årgang = mitårgang;
            Km = mitkm;
            Brændstoftype = mitbrændstof;
        }



    }
}
