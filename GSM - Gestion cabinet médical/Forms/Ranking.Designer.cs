namespace GSM___Gestion_cabinet_médical.Forms
{
    partial class Ranking
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
            this.RankingTitle = new System.Windows.Forms.Label();
            this.RankingTypeOneList = new System.Windows.Forms.ListView();
            this.RankingTypeOneTitle = new System.Windows.Forms.Label();
            this.RankingTypeTwoTitle = new System.Windows.Forms.Label();
            this.RankingTypeTwoList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // RankingTitle
            // 
            this.RankingTitle.AutoSize = true;
            this.RankingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankingTitle.Location = new System.Drawing.Point(30, 28);
            this.RankingTitle.Name = "RankingTitle";
            this.RankingTitle.Size = new System.Drawing.Size(64, 25);
            this.RankingTitle.TabIndex = 0;
            this.RankingTitle.Text = "label1";
            // 
            // RankingTypeOneList
            // 
            this.RankingTypeOneList.HideSelection = false;
            this.RankingTypeOneList.Location = new System.Drawing.Point(33, 104);
            this.RankingTypeOneList.Name = "RankingTypeOneList";
            this.RankingTypeOneList.Size = new System.Drawing.Size(304, 317);
            this.RankingTypeOneList.TabIndex = 1;
            this.RankingTypeOneList.UseCompatibleStateImageBehavior = false;
            // 
            // RankingTypeOneTitle
            // 
            this.RankingTypeOneTitle.AutoSize = true;
            this.RankingTypeOneTitle.Location = new System.Drawing.Point(30, 88);
            this.RankingTypeOneTitle.Name = "RankingTypeOneTitle";
            this.RankingTypeOneTitle.Size = new System.Drawing.Size(35, 13);
            this.RankingTypeOneTitle.TabIndex = 3;
            this.RankingTypeOneTitle.Text = "label1";
            // 
            // RankingTypeTwoTitle
            // 
            this.RankingTypeTwoTitle.AutoSize = true;
            this.RankingTypeTwoTitle.Location = new System.Drawing.Point(465, 88);
            this.RankingTypeTwoTitle.Name = "RankingTypeTwoTitle";
            this.RankingTypeTwoTitle.Size = new System.Drawing.Size(35, 13);
            this.RankingTypeTwoTitle.TabIndex = 4;
            this.RankingTypeTwoTitle.Text = "label2";
            // 
            // RankingTypeTwoList
            // 
            this.RankingTypeTwoList.HideSelection = false;
            this.RankingTypeTwoList.Location = new System.Drawing.Point(468, 104);
            this.RankingTypeTwoList.Name = "RankingTypeTwoList";
            this.RankingTypeTwoList.Size = new System.Drawing.Size(304, 317);
            this.RankingTypeTwoList.TabIndex = 2;
            this.RankingTypeTwoList.UseCompatibleStateImageBehavior = false;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.RankingTypeTwoTitle);
            this.Controls.Add(this.RankingTypeOneTitle);
            this.Controls.Add(this.RankingTypeTwoList);
            this.Controls.Add(this.RankingTypeOneList);
            this.Controls.Add(this.RankingTitle);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RankingTitle;
        private System.Windows.Forms.ListView RankingTypeOneList;
        private System.Windows.Forms.Label RankingTypeOneTitle;
        private System.Windows.Forms.Label RankingTypeTwoTitle;
        private System.Windows.Forms.ListView RankingTypeTwoList;
    }
}