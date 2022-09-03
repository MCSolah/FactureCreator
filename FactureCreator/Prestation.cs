using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureCreator
{
    class Prestation
    {
        private bool lieu_reception; // si TRUE alors Catrache sinon Fontenelles
        private bool type_presta; // si TRUE alors Particuliers sinon Pro
        private string date_facture;
        private string fa_value;
        private string date_reception;

        public Prestation()
        {

        }

//////////// PROPRIETES /////////////

        public bool Lieu
        {
            get { return lieu_reception; }
            set { lieu_reception = value; }
        }

        public bool Type
        {
            get { return type_presta; }
            set { type_presta = value; }
        }

        public string Date_Facture
        {
            get { return date_facture; }
            set 
            {
                string[] words = value.Split('/');
                date_facture = words[2] + words[1] + words[0] ; 
            }
        }

        public string FA_value
        {
            get { return fa_value; }
            set { fa_value = value; }
        }

        public string Date_Reception
        {
            get { return date_reception; }
            set
            {
                string[] words = value.Split(' ');
                date_reception = words[0];
            }
        }
    }
}
