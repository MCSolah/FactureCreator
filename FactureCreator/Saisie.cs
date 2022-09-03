using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureCreator
{
    class Saisie
    {
        private string designation;
        private int qte;
        private double prix;
        private double tva;
        private string Id;

        public Saisie ()
        {
            designation = string.Empty;
            Id = string.Empty;
            qte = 0;
            prix = 0.0;
            tva = -1;
        }

        public Saisie (string design, int quantite, double price, double tVa, string id)
        {
            designation = design;
            Id = id;
            qte = quantite;
            prix = price;
            tva = tVa;
        }

//////////////////// PROPRIETES /////////////////
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public int Qte
        {
            get { return qte; }
            set { qte = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public double Tva
        {
            get { return tva; }
            set { tva = value; }
        }

        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

//////////////////////// METHODES //////////////////////////////////////////
        public override string ToString()
        {
            // Declaration
            string strOut;

            // Initialization
            strOut = string.Format("{0,-160}  ||  {1,-35}  ||  {2,-10}  ||  {3,-10}", Designation, Qte, Prix + "€", Tva + "%");

            // Return the new string
            return strOut;
        }
    }
}
