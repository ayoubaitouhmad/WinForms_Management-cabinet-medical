namespace GSM___Gestion_cabinet_médical.Forms
{
    partial class FirstPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSpecs = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "informations du patient prioritaire.";
            // 
            // lbSpecs
            // 
            this.lbSpecs.AutoSize = true;
            this.lbSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecs.Location = new System.Drawing.Point(23, 296);
            this.lbSpecs.Name = "lbSpecs";
            this.lbSpecs.Size = new System.Drawing.Size(142, 18);
            this.lbSpecs.TabIndex = 21;
            this.lbSpecs.Text = "spécialité demandée";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(23, 225);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(41, 18);
            this.lbGender.TabIndex = 20;
            this.lbGender.Text = "Sexe";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondName.Location = new System.Drawing.Point(23, 152);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(61, 18);
            this.lbSecondName.TabIndex = 19;
            this.lbSecondName.Text = "Prenom";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(26, 173);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(281, 20);
            this.tbLastName.TabIndex = 18;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(23, 80);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(41, 18);
            this.lbFirstName.TabIndex = 17;
            this.lbFirstName.Text = "Nom";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(26, 101);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(281, 20);
            this.tbFirstName.TabIndex = 15;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(26, 246);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(281, 20);
            this.tbGender.TabIndex = 22;
            // 
            // tbSpec
            // 
            this.tbSpec.Location = new System.Drawing.Point(26, 317);
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(281, 20);
            this.tbSpec.TabIndex = 23;
            // 
            // FirstPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 384);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.lbSpecs);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Name = "FirstPatient";
            this.Text = "FirstPatient";
            this.Load += new System.EventHandler(this.FirstPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSpecs;
        internal System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbSpec;
    }
}