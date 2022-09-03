using System;
using System.Windows.Forms;

namespace FactureCreator
{
    partial class MainFacture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFacture));
            this.gBox_Saisie = new System.Windows.Forms.GroupBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_TVA = new System.Windows.Forms.Label();
            this.lbl_PUTTC = new System.Windows.Forms.Label();
            this.lbl_Qte = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.cmbBox_TVA = new System.Windows.Forms.ComboBox();
            this.txtBox_PUTTC = new System.Windows.Forms.TextBox();
            this.txtBox_Qte = new System.Windows.Forms.TextBox();
            this.txtBox_Designation = new System.Windows.Forms.TextBox();
            this.lBox_Apercu = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Facture = new System.Windows.Forms.Button();
            this.gBox_Lieu = new System.Windows.Forms.GroupBox();
            this.rbtn_Fontenelles = new System.Windows.Forms.RadioButton();
            this.rbtn_4H = new System.Windows.Forms.RadioButton();
            this.rbtn_Particulier = new System.Windows.Forms.RadioButton();
            this.rbtn_Pro = new System.Windows.Forms.RadioButton();
            this.gBox_Prestation = new System.Windows.Forms.GroupBox();
            this.gBox_Adresse = new System.Windows.Forms.GroupBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.lbl_arobase = new System.Windows.Forms.Label();
            this.lbl_tiret = new System.Windows.Forms.Label();
            this.txt_Mail2 = new System.Windows.Forms.TextBox();
            this.txt_Mail1 = new System.Windows.Forms.TextBox();
            this.txt_Ville = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.txt_Adr2 = new System.Windows.Forms.TextBox();
            this.txt_Adr1 = new System.Windows.Forms.TextBox();
            this.txt_Nom2 = new System.Windows.Forms.TextBox();
            this.txt_Nom1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_Date = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_About = new System.Windows.Forms.ToolStripLabel();
            this.gBox_Saisie.SuspendLayout();
            this.gBox_Lieu.SuspendLayout();
            this.gBox_Prestation.SuspendLayout();
            this.gBox_Adresse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_Saisie
            // 
            this.gBox_Saisie.Controls.Add(this.btn_Annuler);
            this.gBox_Saisie.Controls.Add(this.btn_Change);
            this.gBox_Saisie.Controls.Add(this.btn_add);
            this.gBox_Saisie.Controls.Add(this.lbl_TVA);
            this.gBox_Saisie.Controls.Add(this.lbl_PUTTC);
            this.gBox_Saisie.Controls.Add(this.lbl_Qte);
            this.gBox_Saisie.Controls.Add(this.lbl_Designation);
            this.gBox_Saisie.Controls.Add(this.cmbBox_TVA);
            this.gBox_Saisie.Controls.Add(this.txtBox_PUTTC);
            this.gBox_Saisie.Controls.Add(this.txtBox_Qte);
            this.gBox_Saisie.Controls.Add(this.txtBox_Designation);
            this.gBox_Saisie.Location = new System.Drawing.Point(16, 417);
            this.gBox_Saisie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Saisie.Name = "gBox_Saisie";
            this.gBox_Saisie.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Saisie.Size = new System.Drawing.Size(1216, 154);
            this.gBox_Saisie.TabIndex = 0;
            this.gBox_Saisie.TabStop = false;
            this.gBox_Saisie.Text = "Saisie de champ";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(1100, 118);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(95, 35);
            this.btn_Annuler.TabIndex = 10;
            this.btn_Annuler.Text = "Annuler Edit.";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(1100, 38);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(95, 35);
            this.btn_Change.TabIndex = 9;
            this.btn_Change.Text = "Modifier";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1100, 78);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_TVA
            // 
            this.lbl_TVA.AutoSize = true;
            this.lbl_TVA.Location = new System.Drawing.Point(969, 54);
            this.lbl_TVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TVA.Name = "lbl_TVA";
            this.lbl_TVA.Size = new System.Drawing.Size(42, 20);
            this.lbl_TVA.TabIndex = 7;
            this.lbl_TVA.Text = "T.V.A";
            // 
            // lbl_PUTTC
            // 
            this.lbl_PUTTC.AutoSize = true;
            this.lbl_PUTTC.Location = new System.Drawing.Point(749, 54);
            this.lbl_PUTTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PUTTC.Name = "lbl_PUTTC";
            this.lbl_PUTTC.Size = new System.Drawing.Size(105, 20);
            this.lbl_PUTTC.TabIndex = 6;
            this.lbl_PUTTC.Text = "Prix Unit. T.T.C.";
            // 
            // lbl_Qte
            // 
            this.lbl_Qte.AutoSize = true;
            this.lbl_Qte.Location = new System.Drawing.Point(667, 54);
            this.lbl_Qte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Qte.Name = "lbl_Qte";
            this.lbl_Qte.Size = new System.Drawing.Size(36, 20);
            this.lbl_Qte.TabIndex = 5;
            this.lbl_Qte.Text = "Qté.";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Location = new System.Drawing.Point(9, 54);
            this.lbl_Designation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(89, 20);
            this.lbl_Designation.TabIndex = 4;
            this.lbl_Designation.Text = "Désignation";
            // 
            // cmbBox_TVA
            // 
            this.cmbBox_TVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_TVA.FormattingEnabled = true;
            this.cmbBox_TVA.Location = new System.Drawing.Point(911, 83);
            this.cmbBox_TVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBox_TVA.Name = "cmbBox_TVA";
            this.cmbBox_TVA.Size = new System.Drawing.Size(160, 28);
            this.cmbBox_TVA.TabIndex = 3;
            // 
            // txtBox_PUTTC
            // 
            this.txtBox_PUTTC.Location = new System.Drawing.Point(739, 83);
            this.txtBox_PUTTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_PUTTC.Name = "txtBox_PUTTC";
            this.txtBox_PUTTC.Size = new System.Drawing.Size(132, 27);
            this.txtBox_PUTTC.TabIndex = 2;
            // 
            // txtBox_Qte
            // 
            this.txtBox_Qte.Location = new System.Drawing.Point(667, 83);
            this.txtBox_Qte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_Qte.Name = "txtBox_Qte";
            this.txtBox_Qte.Size = new System.Drawing.Size(35, 27);
            this.txtBox_Qte.TabIndex = 1;
            // 
            // txtBox_Designation
            // 
            this.txtBox_Designation.Location = new System.Drawing.Point(8, 83);
            this.txtBox_Designation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_Designation.Name = "txtBox_Designation";
            this.txtBox_Designation.Size = new System.Drawing.Size(629, 27);
            this.txtBox_Designation.TabIndex = 0;
            // 
            // lBox_Apercu
            // 
            this.lBox_Apercu.FormattingEnabled = true;
            this.lBox_Apercu.ItemHeight = 20;
            this.lBox_Apercu.Location = new System.Drawing.Point(16, 580);
            this.lBox_Apercu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBox_Apercu.Name = "lBox_Apercu";
            this.lBox_Apercu.Size = new System.Drawing.Size(1215, 244);
            this.lBox_Apercu.TabIndex = 1;
            this.lBox_Apercu.SelectedIndexChanged += new System.EventHandler(this.lBox_Apercu_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(1116, 835);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(95, 35);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Supprimer ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Facture
            // 
            this.btn_Facture.Location = new System.Drawing.Point(511, 857);
            this.btn_Facture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Facture.Name = "btn_Facture";
            this.btn_Facture.Size = new System.Drawing.Size(227, 54);
            this.btn_Facture.TabIndex = 3;
            this.btn_Facture.Text = "Créer Facture Excel";
            this.btn_Facture.UseVisualStyleBackColor = true;
            this.btn_Facture.Click += new System.EventHandler(this.btn_Facture_Click);
            // 
            // gBox_Lieu
            // 
            this.gBox_Lieu.Controls.Add(this.rbtn_Fontenelles);
            this.gBox_Lieu.Controls.Add(this.rbtn_4H);
            this.gBox_Lieu.Location = new System.Drawing.Point(29, 37);
            this.gBox_Lieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Lieu.Name = "gBox_Lieu";
            this.gBox_Lieu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Lieu.Size = new System.Drawing.Size(267, 126);
            this.gBox_Lieu.TabIndex = 8;
            this.gBox_Lieu.TabStop = false;
            this.gBox_Lieu.Text = "Lieu de Réception";
            // 
            // rbtn_Fontenelles
            // 
            this.rbtn_Fontenelles.AutoSize = true;
            this.rbtn_Fontenelles.Location = new System.Drawing.Point(45, 82);
            this.rbtn_Fontenelles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_Fontenelles.Name = "rbtn_Fontenelles";
            this.rbtn_Fontenelles.Size = new System.Drawing.Size(216, 24);
            this.rbtn_Fontenelles.TabIndex = 5;
            this.rbtn_Fontenelles.Text = "Le Domaine des Fontenelles";
            this.rbtn_Fontenelles.UseVisualStyleBackColor = true;
            // 
            // rbtn_4H
            // 
            this.rbtn_4H.AutoSize = true;
            this.rbtn_4H.Location = new System.Drawing.Point(45, 45);
            this.rbtn_4H.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_4H.Name = "rbtn_4H";
            this.rbtn_4H.Size = new System.Drawing.Size(107, 24);
            this.rbtn_4H.TabIndex = 4;
            this.rbtn_4H.Text = "La Catrache";
            this.rbtn_4H.UseVisualStyleBackColor = true;
            // 
            // rbtn_Particulier
            // 
            this.rbtn_Particulier.AutoSize = true;
            this.rbtn_Particulier.Location = new System.Drawing.Point(41, 45);
            this.rbtn_Particulier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_Particulier.Name = "rbtn_Particulier";
            this.rbtn_Particulier.Size = new System.Drawing.Size(101, 24);
            this.rbtn_Particulier.TabIndex = 6;
            this.rbtn_Particulier.TabStop = true;
            this.rbtn_Particulier.Text = "Particuliers";
            this.rbtn_Particulier.UseVisualStyleBackColor = true;
            // 
            // rbtn_Pro
            // 
            this.rbtn_Pro.AutoSize = true;
            this.rbtn_Pro.Location = new System.Drawing.Point(41, 82);
            this.rbtn_Pro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_Pro.Name = "rbtn_Pro";
            this.rbtn_Pro.Size = new System.Drawing.Size(124, 24);
            this.rbtn_Pro.TabIndex = 7;
            this.rbtn_Pro.TabStop = true;
            this.rbtn_Pro.Text = "Professionnels";
            this.rbtn_Pro.UseVisualStyleBackColor = true;
            // 
            // gBox_Prestation
            // 
            this.gBox_Prestation.Controls.Add(this.rbtn_Pro);
            this.gBox_Prestation.Controls.Add(this.rbtn_Particulier);
            this.gBox_Prestation.Location = new System.Drawing.Point(29, 174);
            this.gBox_Prestation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Prestation.Name = "gBox_Prestation";
            this.gBox_Prestation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Prestation.Size = new System.Drawing.Size(267, 126);
            this.gBox_Prestation.TabIndex = 9;
            this.gBox_Prestation.TabStop = false;
            this.gBox_Prestation.Text = "Type de Prestation";
            // 
            // gBox_Adresse
            // 
            this.gBox_Adresse.Controls.Add(this.txt_Tel);
            this.gBox_Adresse.Controls.Add(this.lbl_arobase);
            this.gBox_Adresse.Controls.Add(this.lbl_tiret);
            this.gBox_Adresse.Controls.Add(this.txt_Mail2);
            this.gBox_Adresse.Controls.Add(this.txt_Mail1);
            this.gBox_Adresse.Controls.Add(this.txt_Ville);
            this.gBox_Adresse.Controls.Add(this.txt_CP);
            this.gBox_Adresse.Controls.Add(this.txt_Adr2);
            this.gBox_Adresse.Controls.Add(this.txt_Adr1);
            this.gBox_Adresse.Controls.Add(this.txt_Nom2);
            this.gBox_Adresse.Controls.Add(this.txt_Nom1);
            this.gBox_Adresse.Controls.Add(this.label5);
            this.gBox_Adresse.Controls.Add(this.label4);
            this.gBox_Adresse.Controls.Add(this.label3);
            this.gBox_Adresse.Controls.Add(this.label2);
            this.gBox_Adresse.Controls.Add(this.lbl_Nom);
            this.gBox_Adresse.Location = new System.Drawing.Point(351, 37);
            this.gBox_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Adresse.Name = "gBox_Adresse";
            this.gBox_Adresse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_Adresse.Size = new System.Drawing.Size(881, 371);
            this.gBox_Adresse.TabIndex = 10;
            this.gBox_Adresse.TabStop = false;
            this.gBox_Adresse.Text = "Coordonnées Client";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(171, 322);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(185, 27);
            this.txt_Tel.TabIndex = 15;
            // 
            // lbl_arobase
            // 
            this.lbl_arobase.AutoSize = true;
            this.lbl_arobase.Location = new System.Drawing.Point(421, 274);
            this.lbl_arobase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_arobase.Name = "lbl_arobase";
            this.lbl_arobase.Size = new System.Drawing.Size(23, 20);
            this.lbl_arobase.TabIndex = 14;
            this.lbl_arobase.Text = "@";
            // 
            // lbl_tiret
            // 
            this.lbl_tiret.AutoSize = true;
            this.lbl_tiret.Location = new System.Drawing.Point(312, 218);
            this.lbl_tiret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tiret.Name = "lbl_tiret";
            this.lbl_tiret.Size = new System.Drawing.Size(15, 20);
            this.lbl_tiret.TabIndex = 13;
            this.lbl_tiret.Text = "-";
            // 
            // txt_Mail2
            // 
            this.txt_Mail2.Location = new System.Drawing.Point(447, 269);
            this.txt_Mail2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Mail2.Name = "txt_Mail2";
            this.txt_Mail2.Size = new System.Drawing.Size(219, 27);
            this.txt_Mail2.TabIndex = 12;
            // 
            // txt_Mail1
            // 
            this.txt_Mail1.Location = new System.Drawing.Point(171, 269);
            this.txt_Mail1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Mail1.Name = "txt_Mail1";
            this.txt_Mail1.Size = new System.Drawing.Size(245, 27);
            this.txt_Mail1.TabIndex = 11;
            // 
            // txt_Ville
            // 
            this.txt_Ville.Location = new System.Drawing.Point(333, 211);
            this.txt_Ville.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Ville.Name = "txt_Ville";
            this.txt_Ville.Size = new System.Drawing.Size(191, 27);
            this.txt_Ville.TabIndex = 10;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(171, 212);
            this.txt_CP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(132, 27);
            this.txt_CP.TabIndex = 9;
            // 
            // txt_Adr2
            // 
            this.txt_Adr2.Location = new System.Drawing.Point(171, 168);
            this.txt_Adr2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Adr2.Name = "txt_Adr2";
            this.txt_Adr2.Size = new System.Drawing.Size(623, 27);
            this.txt_Adr2.TabIndex = 8;
            // 
            // txt_Adr1
            // 
            this.txt_Adr1.Location = new System.Drawing.Point(171, 132);
            this.txt_Adr1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Adr1.Name = "txt_Adr1";
            this.txt_Adr1.Size = new System.Drawing.Size(623, 27);
            this.txt_Adr1.TabIndex = 7;
            // 
            // txt_Nom2
            // 
            this.txt_Nom2.Location = new System.Drawing.Point(171, 65);
            this.txt_Nom2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nom2.Name = "txt_Nom2";
            this.txt_Nom2.Size = new System.Drawing.Size(623, 27);
            this.txt_Nom2.TabIndex = 6;
            // 
            // txt_Nom1
            // 
            this.txt_Nom1.Location = new System.Drawing.Point(171, 31);
            this.txt_Nom1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nom1.Name = "txt_Nom1";
            this.txt_Nom1.Size = new System.Drawing.Size(623, 27);
            this.txt_Nom1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code Postal - Ville :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(27, 35);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(49, 20);
            this.lbl_Nom.TabIndex = 0;
            this.lbl_Nom.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_Date);
            this.groupBox1.Location = new System.Drawing.Point(29, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(267, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date de Réception";
            // 
            // box_Date
            // 
            this.box_Date.Location = new System.Drawing.Point(8, 37);
            this.box_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.box_Date.MinDate = new System.DateTime(2015, 2, 23, 0, 0, 0, 0);
            this.box_Date.Name = "box_Date";
            this.box_Date.Size = new System.Drawing.Size(219, 27);
            this.box_Date.TabIndex = 0;
            this.box_Date.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1242, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_About
            // 
            this.btn_About.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_About.Image = global::FactureCreator.Properties.Resources.ToolTipIcon;
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(124, 22);
            this.btn_About.Text = " A propos de...";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // MainFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1242, 953);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBox_Adresse);
            this.Controls.Add(this.gBox_Prestation);
            this.Controls.Add(this.gBox_Lieu);
            this.Controls.Add(this.btn_Facture);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lBox_Apercu);
            this.Controls.Add(this.gBox_Saisie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1400, 1050);
            this.Name = "MainFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture Creator";
            this.gBox_Saisie.ResumeLayout(false);
            this.gBox_Saisie.PerformLayout();
            this.gBox_Lieu.ResumeLayout(false);
            this.gBox_Lieu.PerformLayout();
            this.gBox_Prestation.ResumeLayout(false);
            this.gBox_Prestation.PerformLayout();
            this.gBox_Adresse.ResumeLayout(false);
            this.gBox_Adresse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_Saisie;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_TVA;
        private System.Windows.Forms.Label lbl_PUTTC;
        private System.Windows.Forms.Label lbl_Qte;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.ComboBox cmbBox_TVA;
        private System.Windows.Forms.TextBox txtBox_PUTTC;
        private System.Windows.Forms.TextBox txtBox_Qte;
        private System.Windows.Forms.TextBox txtBox_Designation;
        private System.Windows.Forms.ListBox lBox_Apercu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Facture;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.GroupBox gBox_Lieu;
        private System.Windows.Forms.RadioButton rbtn_Pro;
        private System.Windows.Forms.RadioButton rbtn_Particulier;
        private System.Windows.Forms.RadioButton rbtn_Fontenelles;
        private System.Windows.Forms.RadioButton rbtn_4H;
        private System.Windows.Forms.GroupBox gBox_Prestation;
        private System.Windows.Forms.GroupBox gBox_Adresse;
        private System.Windows.Forms.TextBox txt_Ville;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_Adr2;
        private System.Windows.Forms.TextBox txt_Adr1;
        private System.Windows.Forms.TextBox txt_Nom2;
        private System.Windows.Forms.TextBox txt_Nom1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label lbl_arobase;
        private System.Windows.Forms.Label lbl_tiret;
        private System.Windows.Forms.TextBox txt_Mail2;
        private System.Windows.Forms.TextBox txt_Mail1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker box_Date;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btn_About;
        private System.Windows.Forms.Button btn_Annuler;
    }
}

