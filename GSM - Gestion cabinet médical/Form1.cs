using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSM___Gestion_cabinet_médical.Enums;
using GSM___Gestion_cabinet_médical.Models;
using GSM___Gestion_cabinet_médical.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace GSM___Gestion_cabinet_médical
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
            LoadStyling();

          



        }


        private void LoadStyling()
        {
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            foreach (var item in Controls)
            {
                System.Diagnostics.Debug.WriteLine(item.GetType().ToString());
                if (item is Button)
                {
                    buttontStyling((Button)item);
                }
                if (item is Panel)
                {
                    paneltStyling((Panel)item);
                }
                if (item is TextBox)
                {
                    textboxStyling((TextBox)item);
                }
            }
        }
        private void textboxStyling(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Navy;
            textBox.Font = new Font("Segoe UI", 10F);
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }
        private void paneltStyling(Panel panel)
        {
            panel.BackColor = ColorTranslator.FromHtml("#E5E5E5");
        }
        private void buttontStyling(Button button)
        {
            button.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Couleurs
            button.BackColor = ColorTranslator.FromHtml("#FCA311");
            button.ForeColor = ColorTranslator.FromHtml("#14213D");

            // Coins arrondis (nécessite OwnerDraw ou un custom control pour être *vraiment* arrondi)

            // Bordure & apparence
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Taille
            button.Padding = new Padding(10, 6, 10, 6); // simulate px-4 py-2
            button.AutoSize = true;


            button.Font = new Font("Segoe UI", 13F, FontStyle.Regular);


            // Effet de survol (hover)
            button.MouseEnter += (s, e) => {
                button.BackColor = ColorTranslator.FromHtml("#be7702");
                button.ForeColor = ColorTranslator.FromHtml("#000000");
            };
            button.MouseLeave += (s, e) => {
                button.BackColor = ColorTranslator.FromHtml("#FCA311");
                button.ForeColor = ColorTranslator.FromHtml("#14213D");
            };

        }
        /***************************************************/

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            Speciality spec = (Speciality)cbSpecs.SelectedItem;
            Gender gender = (Gender)cbGender.SelectedItem;

            String patientFirstName = tbFirstName.Text;
            String patientLastName = tbLastName.Text;
            String patientAdresse = tbAdrtesse.Text;
            String patientDateNaissance = dtpDob.Text;
            String patientSpecialite = String.Empty;
            String patientGender = cbGender.Text;


            if (patientFirstName.Equals(String.Empty))
            {
                MessageBox.Show("Le nom est obligatoire.", "Messages de validation");
                return;
            }
            if (patientLastName.Equals(String.Empty))
            {
                MessageBox.Show("Le prénom  est obligatoire.", "Messages de validation");
                return;
            }
            if (patientAdresse.Equals(String.Empty))
            {
                MessageBox.Show("L'adresse1  est obligatoire.", "Messages de validation");
                return;
            }

            if (patientDateNaissance.Equals(String.Empty))
            {
                MessageBox.Show("La date de naissance  est obligatoire.", "Messages de validation");
                return;
            }

            if (spec == null)
            {
                MessageBox.Show("La specilalite  est obligatoire.", "Messages de validation");
            }
            else
                patientSpecialite = spec.Name;
            if (patientGender.Equals(String.Empty))
            {
                MessageBox.Show("Le sexe est obligatoire.", "Messages de validation");
            }
            Patient patient = new Patient(
                  patientFirstName, patientLastName, patientAdresse, gender, dtpDob.Value.Date, spec
            );
            Cabinet.AjouterPatient(patient);
            LoadLIst();
            System.Diagnostics.Debug.WriteLine(patient.Nom);
        }



        private void LoadLIst()
        {
            listView1.Items.Clear();
            Cabinet.Patients.ForEach(patientRecord =>
            {
                ListViewItem item = new ListViewItem(patientRecord.Nom);
                item.SubItems.Add(patientRecord.Prenom);
                item.SubItems.Add(patientRecord.Sexe.ToString());
                item.Tag = patientRecord.Id;
                listView1.Items.Add(item);
            });

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem clickedItem = listView1.SelectedItems[0];
            System.Diagnostics.Debug.WriteLine(clickedItem.Tag);

        }

        private void BtnRemoveFromList_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem clickedItem = listView1.SelectedItems[0];
/*                System.Diagnostics.Debug.WriteLine(clickedItem.Tag);*/
                Patient patient = Cabinet.findPationById(int.Parse(clickedItem.Tag.ToString()));
                System.Diagnostics.Debug.WriteLine(patient.ToString());

                tbFirstName.Text = patient.Nom;
                tbLastName.Text = patient.Prenom;
                tbAdrtesse.Text = patient.Adresse;
                dtpDob.Text = patient.DateNaissance.ToString();
                cbSpecs.SelectedItem = patient.SpecialiteDemandee;
                cbGender.SelectedItem = patient.Sexe;

                Cabinet.SupprimerPatient(patient);
                LoadLIst();
            }
            else
                MessageBox.Show(" Aucun patient sélectionné.", "Messages de systeme");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSpecsCombobox();
            loadGenderCombobox();
            InitializeListView();
            dtpDob.Format = DateTimePickerFormat.Short;





        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;


            listView1.Columns.Add("Nom", 100);
            listView1.Columns.Add("Prenom", 100);
            listView1.Columns.Add("Sexe", 100);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            Patient patient = new Patient(
                  "Amina", "ray", "Paris,564546 gloas", Gender.Femme, DateTime.Now, Speciality.DefaultSpecs.First()
            );

            Cabinet.AjouterPatient(patient);
            patient = new Patient(
                "Ayoub", "ait", "Fes,564546 ", Gender.Homme, DateTime.Now, Speciality.DefaultSpecs.First()
            );

            Cabinet.AjouterPatient(patient);
            LoadLIst();


        }
        private void loadSpecsCombobox()
        {
            cbSpecs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpecs.DataSource = Speciality.DefaultSpecs;
            cbSpecs.DisplayMember = "Name";
            cbSpecs.ValueMember = "Id";
            cbSpecs.SelectedIndex = 0;
        }
        private void loadGenderCombobox()
        {

            cbGender.DataSource = Speciality.DefaultSpecs;
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbGender.SelectedIndex = 0;
        }

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            tbFirstName.Text= null;
            tbLastName.Text= null;
            tbAdrtesse.Text= null;
            dtpDob.Format = DateTimePickerFormat.Short;

        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
