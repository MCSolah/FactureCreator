using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FactureCreator
{
    class FillExcelDoc
    {
        private Manager m = null;
        private Calculs calc = null;
        private Client c = null;
        private Prestation p = null;
        private CreateExcelDoc xls = null;


        public FillExcelDoc(Manager manager, Client client, Prestation prestation)
        {
            // On initialise la feuille excel
            xls = new CreateExcelDoc();

            // On récupère la liste des éléments de la facture
            m = manager;

            // On récupère les infos client
            c = client;

            // On récupère les infos prestations (lieu et type de prestation)
            p = prestation;


        }

//////////////// METHODES ///////////////////

        public void Creation_Excel()
        {
            /// Entête
            Logo_Facture();
            Info_Facture();
            Coord_Lieu();
            Coord_Client();
            xls.Worksheet.get_Range("A8:I16").Font.Size = 7.5;

            // Effacer les bordures d'entête
            xls.EraseBorders("A8", "I100");

            /// Corps de facture
            Tab_Facture();
            Tab_Totaux();
            Tab_Virements();
            Final_Totaux();

            /// Pied de page
            Coord_Bancaire();
            Info_Entreprise();

            xls.Worksheet.get_Range("A8:I100").Font.FontStyle = "Futura Light";
        }

        private void Logo_Facture()
        {
            // Si Catrache = TRUE afficher le logo
            if (p.Lieu)
                xls.Worksheet.Shapes.AddPicture(Application.StartupPath + @"..\Samples\Logo4H.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 5, 5, 150, 75);

            // Sinon afficher logo Fontenelles
            else xls.Worksheet.Shapes.AddPicture(Application.StartupPath + @"..\Samples\LogoFontenelles.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 5, 5, 100, 100);
        }

        private void Info_Facture()
        {
            // Forme tableau
            xls.createHeaders(2, 7, "FACTURE", "G2", "I2", 3, "BLUE", true, 10, "");
            xls.createHeaders(3, 7, "Facture n°", "G3", "H3", 2, "", true, 10, "");
            xls.createHeaders(4, 7, "Référence", "G4", "H4", 2, "", true, 10, "");
            xls.createHeaders(5, 7, "Date émission", "G5", "H5", 2, "", true, 10, "");

            // Numéro de facture
            xls.createHeaders(3, 9, "FA"+p.FA_value, "I3", "I3", 1, "", true, 10, "");

            // Référence facture (Gestion Catrache)
            xls.createHeaders(4, 9, "RF"+p.Date_Facture, "I4", "I4", 1, "", true, 10, "");

            // Date de réception
            xls.createHeaders(5, 9, DateTime.Now.ToString("dd/MM/yyyy"), "I5", "I5", 1, "", true, 10, "");

            // Affichage
            xls.BorderAround("G3", "I5");
            xls.CenterText("G2:I5");
            xls.Worksheet.get_Range("G2:I2").Font.ColorIndex = 2;
        }

        private void Coord_Lieu()
        {
            // Nom du domaine
            if (p.Lieu)
            {
                // Catégories
                xls.createHeaders(9, 1, "Nom :", "A9", "A9", 1, "", true, 10, "");
                xls.createHeaders(10, 1, "Adresse :", "A10", "A10", 1, "", true, 10, "");
                xls.createHeaders(11, 1, "CP - Ville :", "A11", "A11", 1, "", true, 10, "");
                xls.createHeaders(12, 1, "E-mail :", "A12", "A12", 1, "", true, 10, "");
                xls.createHeaders(13, 1, "Téléphone :", "A13", "A13", 1, "", true, 10, "");

                // Nom   
                xls.createHeaders(9, 2, "La Catrache", "B9", "B9", 1, "", false, 10, "");

                // Adresse
                xls.createHeaders(10, 2, "17bis Rue de la Forêt", "B10", "C10", 2, "", false, 10, "");

                // CP - Ville
                xls.createHeaders(11, 2, "78125 HERMERAY", "B11", "C11", 2, "", false, 10, "");

                // Mail
                xls.createHeaders(12, 2, "reservation@lacatrache.com", "B12", "D12", 3, "", false, 10, "");

                // Telephone
                xls.createHeaders(13, 2, "06 84 23 88 81 (Mme Haliot)", "B13", "C13", 2, "", false, 10, "");

                // Alignement
                xls.RightText("A9:A13");
                xls.LeftText("B9:D13");
            }
                
            else
            {
                // Catégories
                xls.createHeaders(9, 1, "Nom :", "A9", "A9", 1, "", true, 10, "");
                xls.createHeaders(10, 1, "Adresse :", "A10", "A10", 1, "", true, 10, "");
                xls.createHeaders(11, 1, "CP - Ville :", "A11", "A11", 1, "", true, 10, "");
                xls.createHeaders(12, 1, "E-mail :", "A12", "A12", 1, "", true, 10, "");
                xls.createHeaders(13, 1, "Téléphone :", "A13", "A13", 1, "", true, 10, "");

                // Nom
                xls.createHeaders(9, 2, "Le Domaine des Fontenelles", "B9", "C9", 2, "", false, 10, "");

                // Adresse
                xls.createHeaders(10, 2, "1 route de Mantes", "B10", "B10", 1, "", false, 10, "");

                // CP - Ville
                xls.createHeaders(11, 2, "78490 LES MESNULS", "B11", "C11", 2, "", false, 10, "");

                /// Particuliers
                if(p.Type)
                {
                    // Mail
                    xls.createHeaders(12, 2, "contact@ledomainedesfontenelles.com", "B12", "D12", 3, "", false, 10, "");

                    // Telephone
                    xls.createHeaders(13, 2, "07 88 40 63 43 (M. Haliot)", "B13", "C13", 2, "", false, 10, "");

                }

                else
                {
                    // Mail
                    xls.createHeaders(12, 2, "contactentreprise@ledomainedesfontenelles.com", "B12", "E12", 4, "", false, 10, "");

                    // Telephone
                    xls.createHeaders(13, 2, "06 29 13 37 99 (M. Palisson)", "B13", "C13", 2, "", false, 10, "");
                }

                // Alignement
                xls.RightText("A9:A13");
                xls.LeftText("B9:E13");
                
            }
        }

        private void Coord_Client()
        {
            // Catégories
            xls.createHeaders(9, 6, "Nom :", "F9", "F9", 1, "", true, 10, "");
            xls.createHeaders(10, 6, "Adresse :", "F10", "F10", 1, "", true, 10, "");
            xls.createHeaders(11, 6, "CP - Ville :", "F11", "F11", 1, "", true, 10, "");
            xls.createHeaders(12, 6, "E-mail :", "F12", "F12", 1, "", true, 10, "");
            xls.createHeaders(13, 6, "Téléphone :", "F13", "F13", 1, "", true, 10, "");

            // Nom
            if(c.Nom2 != string.Empty)
            {
                xls.createHeaders(9, 7,c.Nom1 + "\n" + c.Nom2, "G9", "I9", 3, "", false, 10, "");
                xls.Worksheet.get_Range("G9:I9").RowHeight = 20;
            }
                
            else
                xls.createHeaders(9, 7,c.Nom1, "G9", "I9", 3, "", false, 10, "");

            // Adresse
            if(c.Adr2 != string.Empty)
            {
                xls.createHeaders(10, 7,c.Adr1 + "\n" + c.Adr2, "G10", "I10", 3, "", false, 10, "");
                xls.Worksheet.get_Range("G10:I10").RowHeight = 20;
            }
                
            else 
                xls.createHeaders(10, 7, c.Adr1, "G10", "I10", 3, "", false, 10, "");

            // CP - Ville
            xls.createHeaders(11, 7,c.CP + " " + c.Ville, "G11", "I11", 3, "", false, 10, "");

            // Mail
            if(c.Mail1 != string.Empty && c.Mail2 != string.Empty)
            {
                    xls.createHeaders(12, 7, c.Mail1 + "@" + c.Mail2, "G12", "I12", 3, "", false, 10, "");
                    xls.Worksheet.get_Range("G12:I12").RowHeight = 20;
            }
                
            else
                xls.createHeaders(12, 7,"", "G12", "I12", 3, "", false, 10, "");

            // Telephone
            xls.createHeaders(13, 7,c.Tel, "G13", "I13", 3, "", false, 10, "");

            // Alignement
            xls.LeftText("G9:I13");
            xls.RightText("F9:F13");
        }

        private void Tab_Facture()
        {
            /// Entête de colonnes
            // Désignation
            xls.createHeaders(16, 1, "Désignation", "A16", "B16", 2, "BLUE", true, 10, "");

            // Quantité
            xls.createHeaders(16, 3, "Qté", "C16", "C16", 1, "BLUE", true, 10, "");

            // TVA
            xls.createHeaders(16, 4, "% TVA", "D16", "D16", 1, "BLUE", true, 10, "");

            // PUHT
            xls.createHeaders(16, 5, "Prix unitaire\nHT", "E16", "E16", 1, "BLUE", true, 10, "");

            // PUTTC
            xls.createHeaders(16, 6, "Prix unitaire\nTTC", "F16", "F16", 1, "BLUE", true, 10, "");

            // Total HT
            xls.createHeaders(16, 7, "Total\nHT", "G16", "G16", 1, "BLUE", true, 10, "");

            // Total TVA
            xls.createHeaders(16, 8, "Total\nTVA", "H16", "H16", 1, "BLUE", true, 10, "");

            // Total TTC
            xls.createHeaders(16, 9, "Total\nTTC", "I16", "I16", 1, "BLUE", true, 10, "");

            // Affichage
            xls.EraseBorders("A16","I16");
            xls.BorderAround("A16", "I16");
            xls.CenterText("A16:I16");
            xls.Worksheet.get_Range("A16:I16").Font.ColorIndex = 2;

            /// Contenu tableau
            if (m.Count != 0)
            {
                int index = 0;
                int i = 0;
                int j = 0;

                for(i = 17; i<m.Count+17 ; i++)
                {
                    // Initialisation de la calculatrice
                    calc = new Calculs(i.ToString());

                    xls.createHeaders(i, 1, m.GetSaisie(index).Designation, "A" + i.ToString(), "B" + i.ToString(), 2, "", true, 10, "");
                    xls.createHeaders(i, 3, m.GetSaisie(index).Qte.ToString(), "C" + i.ToString(), "C" + i.ToString(), 1, "", false, 10, "");
                    xls.addData(i, 4, m.GetSaisie(index).Tva.ToString(), "D" + i.ToString(), "D" + i.ToString(), "0.0");
                    xls.addData(i, 5, calc.PrixHT, "E" + i.ToString(), "E" + i.ToString(), "#,##0.00€");
                    xls.addData(i, 6, m.GetSaisie(index).Prix.ToString() + "€", "F" + i.ToString(), "F" + i.ToString(), "#,##0.00€");
                    xls.addData(i, 7, calc.TotalHT, "G" + i.ToString(), "G" + i.ToString(), "#,##0.00€");
                    xls.addData(i, 8, calc.TotalTVA, "H" + i.ToString(), "H" + i.ToString(), "#,##0.00€");
                    xls.addData(i, 9, calc.TotalTTC, "I" + i.ToString(), "I" + i.ToString(), "#,##0.00€");

                    index += 1;
                }

                // Ajout lignes
                for (j = i; j < i + 5; j++)
                {
                    // Initialisation de la calculatrice
                    calc = new Calculs(j.ToString());

                    xls.createHeaders(j, 1, "", "A" + j.ToString(), "B" + j.ToString(), 2, "", true, 10, "");
                    xls.addData(j, 3, "", "C" + j.ToString(), "C" + j.ToString(), "0;-0;-;-");
                    xls.addData(j, 4, "", "D" + j.ToString(), "D" + j.ToString(), "0.0;-0.0;-;-");
                    xls.addData(j, 5, calc.PrixHT, "E" + j.ToString(), "E" + j.ToString(), "#,##0.00€;-#,##0.00€;-;-");
                    xls.addData(j, 6, "", "F" + j.ToString(), "F" + j.ToString(), "#,##0.00€;-#,##0.00€;-;-");
                    xls.addData(j, 7, calc.TotalHT, "G" + j.ToString(), "G" + j.ToString(), "#,##0.00€;-#,##0.00€;-;-");
                    xls.addData(j, 8, calc.TotalTVA, "H" + j.ToString(), "H" + j.ToString(), "#,##0.00€;-#,##0.00€;-;-");
                    xls.addData(j, 9, calc.TotalTTC, "I" + j.ToString(), "I" + j.ToString(), "#,##0.00€;-#,##0.00€;-;-");
                }

                    // Affichage
                    xls.EraseBorders("A17", "I" + j.ToString());
                    xls.BorderAround("A17", "B" + j.ToString());
                    xls.BorderAround("C17", "C" + j.ToString());
                    xls.BorderAround("D17", "D" + j.ToString());
                    xls.BorderAround("E17", "E" + j.ToString());
                    xls.BorderAround("F17", "F" + j.ToString());
                    xls.BorderAround("G17", "G" + j.ToString());
                    xls.BorderAround("H17", "H" + j.ToString());
                    xls.BorderAround("I17", "I" + j.ToString());
                    xls.CenterText("A17:I" + j.ToString());

                // Ligne de clôture du tableau
                xls.createHeaders(i, 1, "", "A" + j.ToString(), "I" + j.ToString(), 9, "BLUE", false, 10, "");
                xls.Worksheet.get_Range("A" + j.ToString(), "I" + j.ToString()).RowHeight = 5;

            }
        }

        private void Tab_Totaux()
        {
            // Déclaration 
            int ligne_depart = m.Count + 24;
            int fin_tab = m.Count + 22;
            calc = new Calculs(ligne_depart.ToString(), fin_tab.ToString());

            /// Entêtes
            // Total HT
            xls.createHeaders(ligne_depart, 8, "Total HT", "H"+ligne_depart.ToString(), "H"+ligne_depart.ToString(), 1, "", false, 10, "");
            xls.addData(ligne_depart, 9,calc.TotHT, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");
            ligne_depart += 1;

            // TVA 5,5%
            xls.createHeaders(ligne_depart, 8, "TVA (5,5%)", "H" + ligne_depart.ToString(), "H" + ligne_depart.ToString(), 1, "", false, 10, "");
            xls.addData(ligne_depart, 9, calc.TotTVA5, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");
            ligne_depart += 1;

            // TVA 10%
            xls.createHeaders(ligne_depart, 8, "TVA (10%)", "H" + ligne_depart.ToString(), "H" + ligne_depart.ToString(), 1, "", false, 10, "");
            xls.addData(ligne_depart, 9, calc.TotTVA10, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");
            ligne_depart += 1;

            // TVA 20%
            xls.createHeaders(ligne_depart, 8, "TVA (20%)", "H" + ligne_depart.ToString(), "H" + ligne_depart.ToString(), 1, "", false, 10, "");
            xls.addData(ligne_depart, 9, calc.TotTVA20, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");
            ligne_depart += 1;

            // TVA Total
            xls.createHeaders(ligne_depart, 8, "TVA Total", "H" + ligne_depart.ToString(), "H" + ligne_depart.ToString(), 1, "", false, 10, "");
            xls.addData(ligne_depart, 9, calc.TotTVA, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");
            ligne_depart += 1;

            // Total TTC
            xls.createHeaders(ligne_depart, 8, "Total TTC", "H" + ligne_depart.ToString(), "H" + ligne_depart.ToString(), 1, "", true, 10, "");
            xls.addData(ligne_depart, 9, calc.TotTTC, "I" + ligne_depart.ToString(), "I" + ligne_depart.ToString(), "#,##0.00€");

            /// Affichage
            xls.EraseBorders("H" + (m.Count + 23).ToString(), "I" + (ligne_depart+1).ToString());
            xls.CenterText("H" + (m.Count + 24).ToString() + ":I" + ligne_depart.ToString());
        }

        private void Tab_Virements()
        {
            // Déclaration 
            int depart = m.Count + 31;
            int index = depart + 1;
            int i = 0;

            string dep = "A" + depart.ToString();
            string arr = "I" + depart.ToString();

            /// Entêtes de colonnes
            // Date
            xls.createHeaders(depart, 1, "Date", "A" + depart.ToString(), "B" + depart.ToString(), 2, "BLUE", true, 10, "");

            // Mode
            xls.createHeaders(depart, 3, "Mode", "C" + depart.ToString(), "D" + depart.ToString(), 2, "BLUE", true, 10, "");

            // Référence
            xls.createHeaders(depart, 5, "Référence", "E" + depart.ToString(), "G" + depart.ToString(), 3, "BLUE", true, 10, "");

            // Montant
            xls.createHeaders(depart, 8, "Montant", "H" + depart.ToString(), "I" + depart.ToString(), 2, "BLUE", true, 10, "");

            // Affichage
            xls.EraseBorders(dep, arr);
            xls.BorderAround(dep, arr);
            xls.CenterText(dep + ":" + arr);
            xls.Worksheet.get_Range(dep + ":" + arr).Font.ColorIndex = 2;

            /// Contenu
            for(i = index; i < index + 5; i++)
            {
                // Date
                xls.createHeaders(i, 1, "", "A" + i.ToString(), "B" + i.ToString(), 2, "", false, 10, "");
                xls.addData(i, 1, "", "A" + i.ToString(), "B" + i.ToString(), "dd/MM/yyyy");

                // Mode
                xls.createHeaders(i, 3, "", "C" + i.ToString(), "D" + i.ToString(), 2, "", false, 10, "");

                // Référence
                xls.createHeaders(i, 5, "", "E" + i.ToString(), "G" + i.ToString(), 3, "", false, 10, "");
                     
                // Montant
                xls.createHeaders(i, 8, "", "H" + i.ToString(), "I" + i.ToString(), 2, "", false, 10, "");
                xls.addData(i, 8, "", "H" + i.ToString(), "I" + i.ToString(), "#,##0.00€");
            }

            // Affichage
            xls.EraseBorders("A" + index.ToString(), "I" + i.ToString());
            xls.BorderAround("A" + index.ToString(), "B" + (i - 1).ToString());
            xls.BorderAround("E" + index.ToString(), "G" + (i - 1).ToString());
            xls.BorderAround("H" + index.ToString(), "I" + (i - 1).ToString());
            xls.CenterText(dep + ":I" + (i - 1).ToString());

            /// Clôture
            xls.createHeaders(i, 1, "", "A" + i.ToString(), "I" + i.ToString(), 8, "BLUE", false, 10, "");
            xls.Worksheet.get_Range("A" + i.ToString(), "I" + i.ToString()).RowHeight = 5;
        }

        private void Final_Totaux()
        {
            // Déclaration
            int depart = m.Count + 39;
            int debut_tab = m.Count + 32;
            int fin_tab = m.Count + 37;

            /// Entêtes
            // Solde à payer
            xls.createHeaders(depart, 7, "Solde à payer", "G" + depart.ToString(), "H" + depart.ToString(), 1, "", false, 10, "");
            xls.addData(depart, 9,"=I" + (m.Count + 29) , "I" + depart.ToString(), "I" + depart.ToString(), "#,##0.00€");

            // Montant versé
            xls.createHeaders(depart + 1, 7, "Montant versé", "G" + (depart+1).ToString(), "H" + (depart+1).ToString(), 1, "", false, 10, "");
            xls.addData(depart + 1, 9, "=SUM(H" + debut_tab.ToString() + ":H" + fin_tab.ToString() + ")", "I" + (depart + 1).ToString(), "I" + (depart + 1).ToString(), "-#,##0.00€");
 
            // Solde restant dû
            xls.createHeaders(depart + 2, 7, "Solde restant dû ", "G" + (depart + 2).ToString(), "H" + (depart + 2).ToString(), 1, "", true, 10, "");
            xls.addData(depart + 2, 9, "=I" + depart.ToString() + "-I" + (depart + 1).ToString(), "I" + (depart + 2).ToString(), "I" + (depart + 2).ToString(), "[RED]#,##0.00€");

            /// Affichage
            xls.EraseBorders("G" + (depart - 1).ToString(), "I" + (depart + 3).ToString());
            xls.TopBorder("H" + (depart + 2).ToString(), "I" + (depart + 2).ToString());
            xls.CenterText("I" + depart.ToString() + ":" + "G" + (depart + 3).ToString());
            xls.RightText("G" + depart.ToString() + ":" + "H" + (depart + 3).ToString());
            xls.Worksheet.get_Range("G" + (depart + 2).ToString() + ":" + "H" + (depart + 2).ToString()).Font.Color = System.Drawing.Color.Red.ToArgb();

        }

        private void Coord_Bancaire()
        {
            // Déclaration
            int depart = m.Count + 43;

            // Coordonnées bancaires
            xls.createHeaders(depart, 1, "Coordonnées bancaires", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
            depart += 1;

            // Si VRAI alors Catrache sinon Fontenelles
            if (p.Lieu)
            {
                // Titulaire du compte
                xls.createHeaders(depart, 1, "Titulaire du compte : SARL La Catrache", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // RIB
                xls.createHeaders(depart, 1, "RIB : 30002 00430 0000431078E 63", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // IBAN
                xls.createHeaders(depart, 1, "IBAN : FR65 3000 2004 3000 0043 1078 E63", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // BIC
                xls.createHeaders(depart, 1, "BIC : CRLYFRPP", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
            }

            else
            {
                // Titulaire du compte
                xls.createHeaders(depart, 1, "Titulaire du compte : SAS Le Domaine des Fontenelles", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // RIB
                xls.createHeaders(depart, 1, "RIB : 30002 00430 0000431416N 11", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // IBAN
                xls.createHeaders(depart, 1, "IBAN : FR86 3000 2004 3000 0043 1416 N11", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
                depart += 1;

                // BIC
                xls.createHeaders(depart, 1, "BIC : CRLYFRPP", "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
            }

            /// Affichage
            xls.EraseBorders("A" + (m.Count + 42).ToString(), "I" + (depart + 1).ToString());
            xls.CenterText("A" + (m.Count + 43).ToString() + ":I" + (depart + 1).ToString());

            // Entête soulignée
            xls.Worksheet.get_Range("A" + (m.Count + 43).ToString() + ":I" + (m.Count + 43).ToString()).get_Characters(1, 21).Font.Underline = true;

            // RIB color
            xls.ColorGray_PartCell("A" + (m.Count + 45).ToString() + ":I" + (m.Count + 45).ToString(), 6, 40);

            // IBAN color
            xls.ColorGray_PartCell("A" + (m.Count + 46).ToString() + ":I" + (m.Count + 46).ToString(), 7, 40);

            // BIC color
            xls.ColorGray_PartCell("A" + (m.Count + 47).ToString() + ":I" + (m.Count + 47).ToString(), 6, 40);

        }

        private void Info_Entreprise()
        {
            // Déclaration
            int depart = m.Count + 49;
            int index = depart;
            string type = string.Empty;
            string capital = string.Empty;
            string rcs = string.Empty;
            string siren = string.Empty;
            string intracom = string.Empty;

            // Si VRAI alors Catrache sinon Fontenelles
            if(p.Lieu)
            {
                // SARL
                type = "SARL";

                // Capital
                capital = "15.200,00 €";

                // RCS
                rcs = "Versailles B 507 485 027";

                // Siren
                siren = "507 485 027";

                // N° TVA intracommunautaire
                intracom = "FR 325 074 850 27";
            }

            else
            {
                // SAS
                type = "SAS";

                // Capital
                capital = "1.520.000,00 €";

                // RCS
                rcs = "Versailles B 788 866 630";

                // Siren
                siren = "788 866 630";

                // N° TVA intracommunautaire
                intracom = "FR 137 888 666 30";
            }

            // Type + Capital + RCS
            xls.createHeaders(depart, 1, type + " au capital social de " + capital + ", RCS " + rcs, "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
            depart += 1;

            // SIREN
            xls.createHeaders(depart, 1, "SIREN " + siren, "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");
            depart += 1;

            // N° TVA intracommunautaire
            xls.createHeaders(depart, 1, "N° TVA intracommunautaire " + intracom, "A" + depart.ToString(), "I" + depart.ToString(), 8, "", true, 10, "");

            /// Couleur appliquées au texte
            depart = m.Count + 49;

            // Capital + RCS
            xls.ColorGray_PartCell("A" + depart.ToString() + ":I" + depart.ToString(), type.Length + 23, capital.Length);
            xls.ColorGray_PartCell("A" + depart.ToString() + ":I" + depart.ToString(), type.Length + 23 + capital.Length + 6, rcs.Length);
            depart += 1;

            // Siren
            xls.ColorGray_PartCell("A" + depart.ToString() + ":I" + depart.ToString(), 7, siren.Length);
            depart += 1;

            // N° TVA intracommunautaire
            xls.ColorGray_PartCell("A" + depart.ToString() + ":I" + depart.ToString(), 27, intracom.Length);

            /// Affichage
            xls.EraseBorders("A" + index.ToString(), "I" + (depart + 1).ToString());
            xls.CenterText("A" + index.ToString() + ":I" + (depart + 1).ToString());

        }
    }
}
