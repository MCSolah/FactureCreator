using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureCreator
{
    class Client
    {
        private string nom1;
        private string nom2;
        private string adr1;
        private string adr2;
        private string cp;
        private string ville;
        private string mail1;
        private string mail2;
        private string tel;

        public Client()
        {
            nom1 = string.Empty;
            nom2 = string.Empty;
            adr1 = string.Empty;
            adr2 = string.Empty;
            cp = string.Empty;
            ville = string.Empty;
            mail1 = string.Empty;
            mail2 = string.Empty;
            tel = string.Empty;
        }

        public Client(string n1, string n2, string a1, string a2, string cP, string vil, string m1, string m2, string phone)
        {
            nom1 = n1;
            nom2 = n2;
            adr1 = a1;
            adr2 = a2;
            cp = cP;
            ville = vil;
            mail1 = m1;
            mail2 = m2;
            tel = phone;
        }

////////////////// PROPRIETES /////////////////////////////////

        public string Nom1
        {
            get { return nom1; }
            set { nom1 = value; }
        }

        public string Nom2
        {
            get { return nom2; }
            set { nom2 = value; }
        }

        public string Adr1
        {
            get { return adr1; }
            set { adr1 = value; }
        }

        public string Adr2
        {
            get { return adr2; }
            set { adr2 = value; }
        }

        public string Mail1
        {
            get { return mail1; }
            set { mail1 = value; }
        }

        public string Mail2
        {
            get { return mail2; }
            set { mail2 = value; }
        }

        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

    }
}
