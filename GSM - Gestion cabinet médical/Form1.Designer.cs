namespace GSM___Gestion_cabinet_médical
{
    partial class Form1
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
            this.btnFilterByGender = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnFiltreByAge = new System.Windows.Forms.Button();
            this.btnShowBySpec = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnShowPrioritaireInfos = new System.Windows.Forms.Button();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.BtnResetForm = new System.Windows.Forms.Button();
            this.BtnRemoveFromList = new System.Windows.Forms.Button();
            this.BtnAddToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSpecs = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lbSpecs = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.tbAdrtesse = new System.Windows.Forms.TextBox();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFilterByGender
            // 
            this.btnFilterByGender.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFilterByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByGender.Location = new System.Drawing.Point(1052, 662);
            this.btnFilterByGender.Name = "btnFilterByGender";
            this.btnFilterByGender.Size = new System.Drawing.Size(218, 34);
            this.btnFilterByGender.TabIndex = 52;
            this.btnFilterByGender.Text = "Classer par sexe";
            this.btnFilterByGender.UseVisualStyleBackColor = false;
            this.btnFilterByGender.Click += new System.EventHandler(this.btnFilterByGender_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApp.Location = new System.Drawing.Point(50, 662);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(218, 34);
            this.btnExitApp.TabIndex = 49;
            this.btnExitApp.Text = "Quitter l’application";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnFiltreByAge
            // 
            this.btnFiltreByAge.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltreByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreByAge.Location = new System.Drawing.Point(718, 662);
            this.btnFiltreByAge.Name = "btnFiltreByAge";
            this.btnFiltreByAge.Size = new System.Drawing.Size(218, 34);
            this.btnFiltreByAge.TabIndex = 51;
            this.btnFiltreByAge.Text = "Classer par âge";
            this.btnFiltreByAge.UseVisualStyleBackColor = false;
            this.btnFiltreByAge.Click += new System.EventHandler(this.btnFiltreByAge_Click);
            // 
            // btnShowBySpec
            // 
            this.btnShowBySpec.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnShowBySpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBySpec.Location = new System.Drawing.Point(384, 662);
            this.btnShowBySpec.Name = "btnShowBySpec";
            this.btnShowBySpec.Size = new System.Drawing.Size(218, 34);
            this.btnShowBySpec.TabIndex = 50;
            this.btnShowBySpec.Text = "afficher par spécialité";
            this.btnShowBySpec.UseVisualStyleBackColor = false;
            this.btnShowBySpec.Click += new System.EventHandler(this.btnShowBySpec_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(938, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 516);
            this.panel3.TabIndex = 47;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 386);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Liste d\'attente";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.BtnShowPrioritaireInfos);
            this.panel5.Controls.Add(this.BtnClearList);
            this.panel5.Controls.Add(this.BtnResetForm);
            this.panel5.Controls.Add(this.BtnRemoveFromList);
            this.panel5.Controls.Add(this.BtnAddToList);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(488, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 516);
            this.panel5.TabIndex = 48;
            // 
            // BtnShowPrioritaireInfos
            // 
            this.BtnShowPrioritaireInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowPrioritaireInfos.Location = new System.Drawing.Point(14, 402);
            this.BtnShowPrioritaireInfos.Name = "BtnShowPrioritaireInfos";
            this.BtnShowPrioritaireInfos.Size = new System.Drawing.Size(294, 34);
            this.BtnShowPrioritaireInfos.TabIndex = 19;
            this.BtnShowPrioritaireInfos.Text = "prioritaire";
            this.BtnShowPrioritaireInfos.UseVisualStyleBackColor = true;
            // 
            // BtnClearList
            // 
            this.BtnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearList.Location = new System.Drawing.Point(14, 324);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(294, 34);
            this.BtnClearList.TabIndex = 18;
            this.BtnClearList.Text = "Réinitialiser la liste";
            this.BtnClearList.UseVisualStyleBackColor = true;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // BtnResetForm
            // 
            this.BtnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetForm.Location = new System.Drawing.Point(14, 246);
            this.BtnResetForm.Name = "BtnResetForm";
            this.BtnResetForm.Size = new System.Drawing.Size(294, 34);
            this.BtnResetForm.TabIndex = 17;
            this.BtnResetForm.Text = "Réinitialiser le formulaire";
            this.BtnResetForm.UseVisualStyleBackColor = true;
            this.BtnResetForm.Click += new System.EventHandler(this.BtnResetForm_Click);
            // 
            // BtnRemoveFromList
            // 
            this.BtnRemoveFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveFromList.Location = new System.Drawing.Point(14, 168);
            this.BtnRemoveFromList.Name = "BtnRemoveFromList";
            this.BtnRemoveFromList.Size = new System.Drawing.Size(294, 34);
            this.BtnRemoveFromList.TabIndex = 16;
            this.BtnRemoveFromList.Text = "Retirer un patient de la liste";
            this.BtnRemoveFromList.UseVisualStyleBackColor = true;
            this.BtnRemoveFromList.Click += new System.EventHandler(this.BtnRemoveFromList_Click);
            // 
            // BtnAddToList
            // 
            this.BtnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToList.Location = new System.Drawing.Point(14, 90);
            this.BtnAddToList.Name = "BtnAddToList";
            this.BtnAddToList.Size = new System.Drawing.Size(294, 34);
            this.BtnAddToList.TabIndex = 15;
            this.BtnAddToList.Text = " Ajouter à la liste d’attente";
            this.BtnAddToList.UseVisualStyleBackColor = true;
            this.BtnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Liste des actions";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.cbSpecs);
            this.panel6.Controls.Add(this.cbGender);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.dtpDob);
            this.panel6.Controls.Add(this.lbSpecs);
            this.panel6.Controls.Add(this.lbGender);
            this.panel6.Controls.Add(this.lbDob);
            this.panel6.Controls.Add(this.lbAdresse);
            this.panel6.Controls.Add(this.tbAdrtesse);
            this.panel6.Controls.Add(this.lbSecondName);
            this.panel6.Controls.Add(this.tbLastName);
            this.panel6.Controls.Add(this.lbFirstName);
            this.panel6.Controls.Add(this.tbFirstName);
            this.panel6.Location = new System.Drawing.Point(48, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 516);
            this.panel6.TabIndex = 46;
            // 
            // cbSpecs
            // 
            this.cbSpecs.FormattingEnabled = true;
            this.cbSpecs.Location = new System.Drawing.Point(26, 438);
            this.cbSpecs.Name = "cbSpecs";
            this.cbSpecs.Size = new System.Drawing.Size(281, 21);
            this.cbSpecs.TabIndex = 14;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(26, 366);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(281, 21);
            this.cbGender.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Information sur le patient";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(26, 296);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(281, 20);
            this.dtpDob.TabIndex = 12;
            // 
            // lbSpecs
            // 
            this.lbSpecs.AutoSize = true;
            this.lbSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecs.Location = new System.Drawing.Point(24, 417);
            this.lbSpecs.Name = "lbSpecs";
            this.lbSpecs.Size = new System.Drawing.Size(142, 18);
            this.lbSpecs.TabIndex = 11;
            this.lbSpecs.Text = "spécialité demandée";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(23, 345);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(41, 18);
            this.lbGender.TabIndex = 9;
            this.lbGender.Text = "Sexe";
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDob.Location = new System.Drawing.Point(23, 273);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(130, 18);
            this.lbDob.TabIndex = 7;
            this.lbDob.Text = "Date de naissance";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(23, 201);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(62, 18);
            this.lbAdresse.TabIndex = 5;
            this.lbAdresse.Text = "Adresse";
            // 
            // tbAdrtesse
            // 
            this.tbAdrtesse.Location = new System.Drawing.Point(26, 222);
            this.tbAdrtesse.Name = "tbAdrtesse";
            this.tbAdrtesse.Size = new System.Drawing.Size(281, 20);
            this.tbAdrtesse.TabIndex = 4;
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondName.Location = new System.Drawing.Point(23, 129);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(61, 18);
            this.lbSecondName.TabIndex = 3;
            this.lbSecondName.Text = "Prenom";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(26, 150);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(281, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(23, 57);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(41, 18);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Nom";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(26, 78);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(281, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1327, 784);
            this.Controls.Add(this.btnFilterByGender);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnFiltreByAge);
            this.Controls.Add(this.btnShowBySpec);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilterByGender;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnFiltreByAge;
        private System.Windows.Forms.Button btnShowBySpec;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnShowPrioritaireInfos;
        private System.Windows.Forms.Button BtnClearList;
        private System.Windows.Forms.Button BtnResetForm;
        private System.Windows.Forms.Button BtnRemoveFromList;
        private System.Windows.Forms.Button BtnAddToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbSpecs;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lbSpecs;
        internal System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.TextBox tbAdrtesse;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
    }
}

