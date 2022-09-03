using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// http://csharp.net-informations.com/excel/csharp-create-excel.htm 

namespace FactureCreator
{
    public partial class MainFacture : Form
    {
        private Manager MonManager;
        private Client c;
        private Prestation p;
        private bool xlsOK;

        public MainFacture()
        {
            InitializeComponent();
            FillCombobox();
            InitializeGUI();
        }


///////////////////////////////////////////// METHODES ///////////////////////////////////
        private void InitializeGUI()
        {
            MonManager = new Manager();
            xlsOK = false;

            Hide_Buttons(true);

            this.box_Date.Format = DateTimePickerFormat.Custom;
            this.box_Date.CustomFormat = "dd/MM/yyyy";
        }

        private void UpdateGUI()
        {
            // Champs de saisies
            txtBox_Designation.Text = "";
            txtBox_PUTTC.Text = "";
            txtBox_Qte.Text = "";
            cmbBox_TVA.SelectedIndex = -1;

            // List box
            lBox_Apercu.Items.Clear();

            for(int index = 0; index < MonManager.Count; index++)
            {
                string custom = MonManager.GetSaisieInfo(index);
                lBox_Apercu.Items.Add(custom);
            }
        }

        private void FillCombobox()
        {
            // Declaration of the values
            string[] stringArray = new string[3];
            int i = 0;

            // Fill the array with the corresponding strings
            foreach (TVA value in Enum.GetValues(typeof(TVA)))
            {
                // 1 = Normal
                if (i == 0) stringArray[0] = "5,5 %";

                // 2 = Important
                if (i == 1) stringArray[1] = "10 %";

                // 3= Very Important
                if (i == 2) stringArray[2] = "20 %";

                // We increase i each round
                i++;
            }

            // Fill the box
            cmbBox_TVA.Items.AddRange(stringArray);
        }

        private bool Check_Design(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                return true;
            }

            else MessageBox.Show("Aucune désignation saisie !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private bool Check_Qte(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                return true;
            }

            else MessageBox.Show("Aucune quantité saisie !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private bool Check_Prix(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                return true;
            }

            else MessageBox.Show("Aucun prix saisie !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private double Check_TVA(int index)
        {
            // Declaration
            double valeur;

            // Initialisation 
            valeur = -1;

            if (index == -1)
                MessageBox.Show("Aucune T.V.A. sélectionnée !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (index == 0)
                valeur = 5.5;

            else if (index == 1)
                valeur = 10;

            else if (index == 2)
                valeur = 20;

            return valeur;
        }

        private void Input_Client()
        {
            // Initialisation
            c = new Client();

            // Nom
            c.Nom1 = txt_Nom1.Text.Trim();
            c.Nom2 = txt_Nom2.Text.Trim();

            // Adresse
            c.Adr1 = txt_Adr1.Text.Trim();
            c.Adr2 = txt_Adr2.Text.Trim();
            c.CP = txt_CP.Text.Trim();
            c.Ville = txt_Ville.Text.Trim();

            // Mail
            c.Mail1 = txt_Mail1.Text.Trim();
            c.Mail2 = txt_Mail2.Text.Trim();

            // Telephone
            c.Tel = txt_Tel.Text.Trim();
        }

        private void Input_Presta()
        {
            // Initialisation
            p = new Prestation();

            // Lieu
            p.Lieu = rbtn_4H.Checked;

            // Type de prestation
            p.Type = rbtn_Particulier.Checked;

            // Date de saisie de la facture
            p.Date_Reception = DateTime.Now.ToString();

            // Date de la réception
            p.Date_Facture = box_Date.Text;
        }

        private void Hide_Buttons(bool add)
        {
            btn_add.Visible = add;
            btn_Change.Visible = !add;
            btn_Annuler.Visible = !add;
            btn_delete.Visible = !add;

            if(btn_Change.Visible)
            {
                btn_Annuler.Visible = btn_Change.Visible;
                btn_delete.Visible = btn_Change.Visible;
            }
        }

        
///////////////////////////////////////////// EVENTS ///////////////////////////////////

        private void btn_add_Click(object sender, EventArgs e)
                {
                    // Declaration
                    Saisie MaSaisie = new Saisie();
                    bool check;
                    int temp;
                    double temp2;

                    /// On récupère les valeurs
                    // Désignation
                    if (Check_Design(txtBox_Designation.Text))
                    {
                        MaSaisie.Designation = txtBox_Designation.Text.Trim();
                    }

                    // Quantité
                    if (Check_Qte(txtBox_Qte.Text))
                    {
                        check = int.TryParse(txtBox_Qte.Text, out temp);

                        if(check)
                        {
                            MaSaisie.Qte = temp;
                        }
                        
                        else MessageBox.Show("Valeur quantité invalide !","Oups !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    // Prix
                    if (Check_Prix(txtBox_PUTTC.Text))
                    {
                        check = double.TryParse(txtBox_PUTTC.Text, out temp2);

                        if(check)
                        {
                            MaSaisie.Prix = temp2;
                        }

                        else MessageBox.Show("Valeur prix invalide !","Oups !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    // TVA
                    MaSaisie.Tva = Check_TVA(cmbBox_TVA.SelectedIndex);
 
                    /// Quand toutes les saisies sont bonnes
                    if(MaSaisie.Designation != string.Empty && MaSaisie.Qte != 0 && MaSaisie.Prix != 0.0 && MaSaisie.Tva != -1)
                    {
                        MonManager.AddSaisie(MaSaisie);

                        // On actualise
                        UpdateGUI();
                    }
                    
                    
                }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Declaration
            int index;

            // Masquer Modifier
            Hide_Buttons(true);

            // Initialization
            index = lBox_Apercu.SelectedIndex; // A list starts at the index 1 and not 0

            // If a customer has been selected, delete it and update
            if (MonManager.DeleteSaisie(index+1))
            {
                UpdateGUI();
            }

            else MessageBox.Show("Aucune saisie n'a été sélectionnée !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lBox_Apercu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declaration
            int index;

            // Initialisation
            index = lBox_Apercu.SelectedIndex;

            // Masquer ajouter
            if(index != -1)
            {
                Hide_Buttons(false);
            }
            

            // Replacer dans les champs
            txtBox_Designation.Text = MonManager.GetSaisie(index).Designation;
            txtBox_Qte.Text = MonManager.GetSaisie(index).Qte.ToString();
            txtBox_PUTTC.Text = MonManager.GetSaisie(index).Prix.ToString();

            if (MonManager.GetSaisie(index).Tva == 5.5) cmbBox_TVA.SelectedIndex = 0;
            else if (MonManager.GetSaisie(index).Tva == 10) cmbBox_TVA.SelectedIndex = 1;
            else if (MonManager.GetSaisie(index).Tva == 20) cmbBox_TVA.SelectedIndex = 2;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            // Declaration
            int index;
            int qte;
            double prix;
            bool check;

            Saisie new_saisie;

            // Initialisation
            index = lBox_Apercu.SelectedIndex;

            if(Check_Design(txtBox_Designation.Text) && Check_Qte(txtBox_Qte.Text) && Check_Prix(txtBox_PUTTC.Text) && Check_TVA(cmbBox_TVA.SelectedIndex) != -1)
            {
                if (index != -1)
                {
                    check = int.TryParse(txtBox_Qte.Text, out qte);

                        if(check)
                        {
                            check = double.TryParse(txtBox_PUTTC.Text, out prix);

                        if(check)
                        {
                                new_saisie = new Saisie(txtBox_Designation.Text,qte,prix,Check_TVA(cmbBox_TVA.SelectedIndex),MonManager.GetSaisie(index).ID);
                                MonManager.ChangeSaisie(new_saisie, index);

                                // Masquer Modifier
                                Hide_Buttons(true);

                                UpdateGUI();
                        }

                        else MessageBox.Show("Valeur prix invalide !","Oups !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                        else MessageBox.Show("Valeur quantité invalide !","Oups !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

                else MessageBox.Show("Aucune saisie n'a été sélectionnée !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            


        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            // Masquer Modifier
            Hide_Buttons(true);

            // Vider les champs
            UpdateGUI();
        }

        /// <summary>
        /// Format A4 : Colonne max = G
        ///             Ligne max = 50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Facture_Click(object sender, EventArgs e)
        {
            // Le bouton a été cliqué donc les infos envoyées sur un Excel
            xlsOK = true;

            // On récupère les infos prestations et clients
            Input_Client();
            
            // On récupère les conditions de factures (lieu de réception et type)
            Input_Presta();

            // S'il y a au moins une saisie
            if(MonManager.Count != 0)
            {
                // Gérer le numéro de facture
                // Si Catrache = TRUE afficher le logo
                int tmp_FA = 0;

                if (p.Lieu)
                {
                    p.FA_value = System.IO.File.ReadAllText(Application.StartupPath + @"..\Samples\FA_Number_Catrache.txt");
                    tmp_FA = int.Parse(p.FA_value) + 1;
                    File.WriteAllText(Application.StartupPath + @"..\Samples\FA_Number_Catrache.txt", tmp_FA.ToString());
                }

                // Sinon afficher logo Fontenelles
                else
                {
                    p.FA_value = System.IO.File.ReadAllText(Application.StartupPath + @"..\Samples\FA_Number_Fontenelles.txt");
                    tmp_FA = int.Parse(p.FA_value) + 1;
                    File.WriteAllText(Application.StartupPath + @"..\Samples\FA_Number_Fontenelles.txt", tmp_FA.ToString());
                }

                tmp_FA = 0;

            // Créer le document Excel
            FillExcelDoc xlsDoc = new FillExcelDoc(MonManager,c,p);

                xlsDoc.Creation_Excel();
            }
            
            else
            {
                MessageBox.Show("Erreur : Absence d'élément de facture.\n\nAucune facture ne peut être éditée.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Declaration
            DialogResult dr;
            string message;
            string caption;

            // Initialization
            message = "Vous n'avez pas édité de facture.\nÊtes-vous sûr de vouloir quitter l'application ?";
            caption = "Pensez-y !";

            // If the user has not clicked on the Ok or Cancel button
            if (!xlsOK)
            {
                // Display the box
                dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Don't close the form
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }

                // Close the form
                else e.Cancel = false;
            }

            // If the user has clicked on the Ok or Cancel button
            else
            {
                // If the user has clicked on the Ok button and all the values have been checked
                if (xlsOK)
                {
                    e.Cancel = false;
                }

                else
                {
                    // Don't close the form
                    e.Cancel = true;

                    // Restart the bool 
                    xlsOK = false;
                }
            }

            base.OnClosing(e);
        }
    }
}
