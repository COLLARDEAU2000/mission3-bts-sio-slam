﻿
namespace Mission3GSB
{
    partial class FrmVisualisation
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
            this.components = new System.ComponentModel.Container();
            this.buttonEnregistrerXml = new System.Windows.Forms.Button();
            this.comboBoxVisteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LancerFiltreRapport = new System.Windows.Forms.Button();
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIdRapport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxBilan = new System.Windows.Forms.TextBox();
            this.textIdRapports = new System.Windows.Forms.Label();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIdFamille = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdMedicament = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.textBoxEffets = new System.Windows.Forms.TextBox();
            this.textBoxComposition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxContreIndication = new System.Windows.Forms.TextBox();
            this.bdgRapports = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnregistrerXml
            // 
            this.buttonEnregistrerXml.Location = new System.Drawing.Point(510, 495);
            this.buttonEnregistrerXml.Name = "buttonEnregistrerXml";
            this.buttonEnregistrerXml.Size = new System.Drawing.Size(145, 23);
            this.buttonEnregistrerXml.TabIndex = 1;
            this.buttonEnregistrerXml.Text = "Generer le fichier xml";
            this.buttonEnregistrerXml.UseVisualStyleBackColor = true;
            this.buttonEnregistrerXml.Click += new System.EventHandler(this.buttonEnregistrerXml_Click);
            // 
            // comboBoxVisteur
            // 
            this.comboBoxVisteur.FormattingEnabled = true;
            this.comboBoxVisteur.Location = new System.Drawing.Point(343, 62);
            this.comboBoxVisteur.Name = "comboBoxVisteur";
            this.comboBoxVisteur.Size = new System.Drawing.Size(108, 21);
            this.comboBoxVisteur.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID visiteur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date de cration : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LancerFiltreRapport);
            this.groupBox1.Controls.Add(this.comboBoxMedecin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxVisteur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(134, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 126);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre  Rapport  :";
            // 
            // LancerFiltreRapport
            // 
            this.LancerFiltreRapport.Location = new System.Drawing.Point(376, 97);
            this.LancerFiltreRapport.Name = "LancerFiltreRapport";
            this.LancerFiltreRapport.Size = new System.Drawing.Size(75, 23);
            this.LancerFiltreRapport.TabIndex = 24;
            this.LancerFiltreRapport.Text = "Lancer";
            this.LancerFiltreRapport.UseVisualStyleBackColor = true;
            this.LancerFiltreRapport.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(561, 63);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(108, 21);
            this.comboBoxMedecin.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID Medecin : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2022, 10, 2, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMotif);
            this.groupBox2.Controls.Add(this.textBoxIdRapport);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.textBoxBilan);
            this.groupBox2.Controls.Add(this.textIdRapports);
            this.groupBox2.Location = new System.Drawing.Point(134, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 159);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Element Rapport fiche initiale :";
            // 
            // textBoxIdRapport
            // 
            this.textBoxIdRapport.Location = new System.Drawing.Point(6, 80);
            this.textBoxIdRapport.Name = "textBoxIdRapport";
            this.textBoxIdRapport.ReadOnly = true;
            this.textBoxIdRapport.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdRapport.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Motif : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(247, 64);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 25;
            this.label.Text = "Bilan :";
            // 
            // textBoxBilan
            // 
            this.textBoxBilan.Location = new System.Drawing.Point(250, 80);
            this.textBoxBilan.Multiline = true;
            this.textBoxBilan.Name = "textBoxBilan";
            this.textBoxBilan.ReadOnly = true;
            this.textBoxBilan.Size = new System.Drawing.Size(201, 52);
            this.textBoxBilan.TabIndex = 24;
            this.textBoxBilan.TextChanged += new System.EventHandler(this.textBoxBilan_TextChanged);
            // 
            // textIdRapports
            // 
            this.textIdRapports.AutoSize = true;
            this.textIdRapports.Location = new System.Drawing.Point(6, 64);
            this.textIdRapports.Name = "textIdRapports";
            this.textIdRapports.Size = new System.Drawing.Size(59, 13);
            this.textIdRapports.TabIndex = 24;
            this.textIdRapports.Text = "idRapport :";
            this.textIdRapports.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Location = new System.Drawing.Point(549, 80);
            this.textBoxMotif.Multiline = true;
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.ReadOnly = true;
            this.textBoxMotif.Size = new System.Drawing.Size(212, 52);
            this.textBoxMotif.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxContreIndication);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxComposition);
            this.groupBox3.Controls.Add(this.textBoxEffets);
            this.groupBox3.Controls.Add(this.textBoxNomCommercial);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxIdFamille);
            this.groupBox3.Controls.Add(this.textBoxQuantite);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxIdMedicament);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(58, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(943, 159);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Element Rapport Extension  :";
            // 
            // textBoxIdFamille
            // 
            this.textBoxIdFamille.Location = new System.Drawing.Point(210, 63);
            this.textBoxIdFamille.Multiline = true;
            this.textBoxIdFamille.Name = "textBoxIdFamille";
            this.textBoxIdFamille.ReadOnly = true;
            this.textBoxIdFamille.Size = new System.Drawing.Size(88, 20);
            this.textBoxIdFamille.TabIndex = 27;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(9, 63);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.ReadOnly = true;
            this.textBoxQuantite.Size = new System.Drawing.Size(44, 20);
            this.textBoxQuantite.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "IdFamille :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "idMedicament :";
            // 
            // textBoxIdMedicament
            // 
            this.textBoxIdMedicament.Location = new System.Drawing.Point(81, 63);
            this.textBoxIdMedicament.Multiline = true;
            this.textBoxIdMedicament.Name = "textBoxIdMedicament";
            this.textBoxIdMedicament.ReadOnly = true;
            this.textBoxIdMedicament.Size = new System.Drawing.Size(93, 20);
            this.textBoxIdMedicament.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantite : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Effets  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Composition  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nom Commercial :";
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(324, 63);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomCommercial.TabIndex = 31;
            this.textBoxNomCommercial.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxEffets
            // 
            this.textBoxEffets.Location = new System.Drawing.Point(586, 63);
            this.textBoxEffets.Name = "textBoxEffets";
            this.textBoxEffets.ReadOnly = true;
            this.textBoxEffets.Size = new System.Drawing.Size(100, 20);
            this.textBoxEffets.TabIndex = 32;
            // 
            // textBoxComposition
            // 
            this.textBoxComposition.Location = new System.Drawing.Point(458, 63);
            this.textBoxComposition.Name = "textBoxComposition";
            this.textBoxComposition.ReadOnly = true;
            this.textBoxComposition.Size = new System.Drawing.Size(100, 20);
            this.textBoxComposition.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(696, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Contre Indications :";
            // 
            // textBoxContreIndication
            // 
            this.textBoxContreIndication.Location = new System.Drawing.Point(699, 63);
            this.textBoxContreIndication.Multiline = true;
            this.textBoxContreIndication.Name = "textBoxContreIndication";
            this.textBoxContreIndication.ReadOnly = true;
            this.textBoxContreIndication.Size = new System.Drawing.Size(220, 80);
            this.textBoxContreIndication.TabIndex = 35;
            this.textBoxContreIndication.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bdgRapports
            // 
            this.bdgRapports.DataSource = typeof(Mission3GSB.rapport);
            // 
            // FrmVisualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEnregistrerXml);
            this.Name = "FrmVisualisation";
            this.Text = "FrmVisualisation";
            this.Load += new System.EventHandler(this.FrmVisualisation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgRapports;
        private System.Windows.Forms.ComboBox comboBoxVisteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEnregistrerXml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textIdRapports;
        private System.Windows.Forms.Button LancerFiltreRapport;
        private System.Windows.Forms.TextBox textBoxIdRapport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxBilan;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxIdFamille;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdMedicament;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxComposition;
        private System.Windows.Forms.TextBox textBoxEffets;
        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxContreIndication;
        private System.Windows.Forms.Label label11;
    }
}