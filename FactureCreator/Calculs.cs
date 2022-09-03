using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureCreator
{
    class Calculs
    {
        private string prixHT;
        private string totalHT;
        private string totalTVA;
        private string totalTTC;
        private string ligne;
        private string fin;
        private string totHT;
        private string totTVA5;
        private string totTVA10;
        private string totTVA20;
        private string totTVA;
        private string totTTC;

        public Calculs()
        {
            prixHT = string.Empty;
            totalHT = string.Empty;
            totalTTC = string.Empty;
            totalTVA = string.Empty;
            ligne = string.Empty;
        }

        public Calculs(string index_ligne)
        {
            prixHT = string.Empty;
            totalHT = string.Empty;
            totalTTC = string.Empty;
            totalTVA = string.Empty;
            ligne = index_ligne;
        }

        public Calculs(string index_ligne, string fin_tab)
        {
            totHT = string.Empty;
            totTTC = string.Empty;
            totTVA = string.Empty;
            totTVA5 = string.Empty;
            totTVA10 = string.Empty;
            totTVA20 = string.Empty;
            ligne = index_ligne.ToString();
            fin = fin_tab;
        }

//////////////////// PROPRIETES //////////////////////////
        
        public string PrixHT
        {
            get { return Calcul_PrixHT(); }
        }

        public string TotalHT
        {
            get { return Calcul_TotalHT(); }
        }

        public string TotalTVA
        {
            get { return Calcul_TotalTVA(); }
        }

        public string TotalTTC
        {
            get { return Calcul_TotalTTC(); }
        }

        public string TotTVA
        {
            get { return Calcul_TotTVA(); }
        }

        public string TotTVA5
        {
            get { return Calcul_TotTVA5(); }
        }

        public string TotTVA10
        {
            get { return Calcul_TotTVA10(); }
        }

        public string TotTVA20
        {
            get { return Calcul_TotTVA20(); }
        }

        public string TotTTC
        {
            get { return Calcul_TotTTC(); }
        }

        public string TotHT
        {
            get { return Calcul_TotHT(); }
        }

/////////////////// METHODES /////////////////////////////

        private string Calcul_PrixHT()
        {
            prixHT = "=F" + ligne + "/(1+D" + ligne + "/100)";
            return prixHT;
        }

        private string Calcul_TotalHT()
        {

            totalHT = "=(" + "F"+ ligne + "/(1+D" + ligne + "/100))" + "*C" + ligne;
            return totalHT;
        }

        private string Calcul_TotalTVA()
        {
            totalTVA = "=(F" + ligne + "*C" + ligne + ")-((" + "F" + ligne + "/(1+D" + ligne + "/100))" + "*C" + ligne + ")";
            return totalTVA;
        }

        private string Calcul_TotalTTC()
        {
            totalTTC = "=F" + ligne + "*C" + ligne;
            return totalTTC;
        }

        private string Calcul_TotTVA()
        {
            string ligne2 = (Convert.ToInt16(ligne) + 1).ToString();
            string ligne4 = (Convert.ToInt16(ligne) + 3).ToString();

            totTVA = "=SUM(I" + ligne2 + ":I" + ligne4 + ")";
            return totTVA;
        }

        private string Calcul_TotTVA5()
        {
            totTVA5 = "=SUMIF(D17:D" + fin + ",\"=5,5\",H17:H" + fin + ")";
            return totTVA5;
        }

        private string Calcul_TotTVA10()
        {
            totTVA10 = "=SUMIF(D17:D" + fin + ",\"=10\",H17:H" + fin + ")";
            return totTVA10;
        }

        private string Calcul_TotTVA20()
        {
            totTVA20 = "=SUMIF(D17:D" + fin + ",\"=20\",H17:H" + fin + ")";
            return totTVA20;
        }

        private string Calcul_TotTTC()
        {
            string ligne5 = (Convert.ToInt16(ligne) + 4).ToString();

            totTTC = "=I" + ligne + "+I" + ligne5;
            return totTTC;
        }

        private string Calcul_TotHT()
        {
            totHT = "=SUM(G17:G" + fin + ")";
            return totHT;
        }
    }
}
