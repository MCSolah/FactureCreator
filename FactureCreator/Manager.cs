using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureCreator
{
    class Manager
    {
        private List<Saisie> SaisieList;

        public Manager()
        {
            SaisieList = new List<Saisie>();
        }

/////////////////////// PROPRIETES ////////////////////////////
        public int Count
        {
            get { return SaisieList.Count; }
        }

        public int GetNewID
        {
            get { return SaisieList.Count; }
        }

/////////////////////// METHODES ////////////////////////////

        public bool AddSaisie(Saisie saisie)
        {
            // Declaration
            bool ok;

            // Initialization
            ok = true;

            // Check if the customerIn is not null and then add
            if (saisie != null)
            {
                // Add the customer to the list
                SaisieList.Add(saisie);

                saisie.ID = GetNewID.ToString();
            }

            else ok = false;

            return ok;
        }

        public bool ChangeSaisie(Saisie saisie, int index)
        {
            // Declaration
            bool ok;

            // Initialization
            ok = true;

            // Check if the index is inbetween 0 and the number of customers
            if (index >= 0 && index <= Count)
            {
                // Delete the previous version of the customer
                DeleteSaisie(index+1);

                // Insert the corrected version at the same index
                SaisieList.Insert(index, saisie);
            }

            else ok = false;

            return ok;
        }

        public bool DeleteSaisie(int index)
        {
            // Declaration
            bool ok;
            Saisie deletedSai;

            // Initialization
            ok = true;

            // Check if the index is inbetween 0 and the number of customers
            if (index >= 0 && index <= Count)
            {
                // Store the customer to delete in a customer object if it exists otherwise it returns null
                deletedSai = SaisieList.SingleOrDefault(x => Int32.Parse(x.ID) == index);

                // Delete the selected customer
                SaisieList.Remove(deletedSai);
            }

            else ok = false;

            return ok;
        }

        public Saisie GetSaisie(int index)
        {
            // Declaration
            Saisie saisie;

            // Initialisation
            saisie = new Saisie();

            // Get the customer
            if (index >= 0 && index <= SaisieList.Count)
            {
                saisie = SaisieList[index];
            }

            return saisie;
        }

        public string GetSaisieInfo(int index)
        {
            // Declaration
            string saisieInfo;

            // Store the formatted strings of each customer
            saisieInfo = GetSaisie(index).ToString();

            return saisieInfo;
        }
    }
}
