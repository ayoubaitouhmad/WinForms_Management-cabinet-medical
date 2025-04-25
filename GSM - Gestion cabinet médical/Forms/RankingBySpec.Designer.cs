namespace GSM___Gestion_cabinet_médical.Forms
{
    partial class RankingBySpec
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
            this.DefaultPanel = new System.Windows.Forms.Panel();
            this.DefaultPanelLabel = new System.Windows.Forms.Label();
            this.DefaultPanelListView = new System.Windows.Forms.ListView();
            this.DefaultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultPanel
            // 
            this.DefaultPanel.Controls.Add(this.DefaultPanelListView);
            this.DefaultPanel.Controls.Add(this.DefaultPanelLabel);
            this.DefaultPanel.Location = new System.Drawing.Point(45, 74);
            this.DefaultPanel.Name = "DefaultPanel";
            this.DefaultPanel.Size = new System.Drawing.Size(285, 346);
            this.DefaultPanel.TabIndex = 0;
            // 
            // DefaultPanelLabel
            // 
            this.DefaultPanelLabel.AutoSize = true;
            this.DefaultPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultPanelLabel.Location = new System.Drawing.Point(14, 13);
            this.DefaultPanelLabel.Name = "DefaultPanelLabel";
            this.DefaultPanelLabel.Size = new System.Drawing.Size(192, 18);
            this.DefaultPanelLabel.TabIndex = 0;
            this.DefaultPanelLabel.Text = "dsqssssssssssssssssssss";
            // 
            // DefaultPanelListView
            // 
            this.DefaultPanelListView.HideSelection = false;
            this.DefaultPanelListView.Location = new System.Drawing.Point(17, 34);
            this.DefaultPanelListView.Name = "DefaultPanelListView";
            this.DefaultPanelListView.Size = new System.Drawing.Size(247, 285);
            this.DefaultPanelListView.TabIndex = 1;
            this.DefaultPanelListView.UseCompatibleStateImageBehavior = false;
            // 
            // RankingBySpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 637);
            this.Controls.Add(this.DefaultPanel);
            this.Name = "RankingBySpec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RankingBySpec";
            this.Load += new System.EventHandler(this.RankingBySpec_Load);
            this.DefaultPanel.ResumeLayout(false);
            this.DefaultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DefaultPanel;
        private System.Windows.Forms.ListView DefaultPanelListView;
        private System.Windows.Forms.Label DefaultPanelLabel;
    }
}