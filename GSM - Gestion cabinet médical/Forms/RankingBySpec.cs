using GSM___Gestion_cabinet_médical.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace GSM___Gestion_cabinet_médical.Forms
{
    public partial class RankingBySpec : Form
    {
        public RankingBySpec()
        {
            InitializeComponent();
            CreateDynamicPanels();
            DefaultPanel.Hide();

            /*cc(this);*/
        }


        private void cc(Control control)
        {
          
            foreach (Control item in control.Controls)
            {
                System.Diagnostics.Debug.WriteLine(item.Name);
                if (item.HasChildren)
                {
                    cc(item);
                }
            }
            
        }

        private void RankingBySpec_Load(object sender, EventArgs e)
        {

        }


        private void CreateDynamicPanels()
        {
            
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill; 
            flowPanel.WrapContents = true;   
            flowPanel.AutoScroll = true;     
            flowPanel.Padding = new Padding(10);
            flowPanel.FlowDirection = FlowDirection.LeftToRight;

            this.Controls.Add(flowPanel);






            int i = 0;
            foreach(Speciality Speciality in Speciality.DefaultSpecs )
            {
                Control panel = (Control)Activator.CreateInstance(DefaultPanel.GetType());
                panel.Size = DefaultPanel.Size;
                panel.Margin = new Padding(10);
                panel.BackColor = ColorTranslator.FromHtml("#E5E5E5");
                panel.Name = "Panel" + i;
                panel.Tag = i;
                foreach (Control child in DefaultPanel.Controls)
                {
                    Control childClone = (Control)Activator.CreateInstance(child.GetType());
                    childClone.Text = child.Text;
                    childClone.Size = child.Size;
                    childClone.Location = child.Location;
                    childClone.Font = child.Font;
                    childClone.BackColor = child.BackColor;
                    string labelName = child.GetType().ToString().Split('.').Last();

                    childClone.Name = labelName;
                    panel.Controls.Add(childClone);

                }

                Label label = (Label)panel.Controls["Label"];
                ListView listView = (ListView)panel.Controls["listView"];

                label.Text = Speciality.Name;
                listView.Clear();

                listView.View = View.Details;
                listView.FullRowSelect = true;
                listView.GridLines = true;
                listView.Columns.Add("Nom", 100);
                listView.Columns.Add("Prenom", 100);
                listView.Columns.Add("Sexe", 100);
                listView.View = View.Details;
                listView.FullRowSelect = true;

                Cabinet.PatientsParSpecialite(Speciality).ForEach(patientRecord =>
                {
                    ListViewItem item = new ListViewItem(patientRecord.Nom);
                    item.SubItems.Add(patientRecord.Prenom);
                    item.SubItems.Add(patientRecord.Sexe.ToString());
                    item.Tag = patientRecord.Id;
                    listView.Items.Add(item);
                });


                System.Diagnostics.Debug.WriteLine(Cabinet.PatientsParSpecialite(Speciality).Count);

                flowPanel.Controls.Add(panel);
                i++;
            }
        }

    }
}
