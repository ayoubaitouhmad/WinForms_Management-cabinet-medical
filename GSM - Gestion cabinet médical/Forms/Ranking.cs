using GSM___Gestion_cabinet_médical.Enums;
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
    public partial class Ranking : Form
    {
        private int FormRole;
        public static int FormRankingByAge = 0;
        public static int FormRankingByGender = 1 ;

        /*public static String RankingTypeOneList;
        public static String RankingTypeTwoList;*/



        public Ranking(int formRole)
        {
            InitializeComponent();
            FormRole = formRole;
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            switch (FormRole)
            {
                case var value when value == Ranking.FormRankingByAge:

                    LoadFormForRankingByAge();
                    break;
                case var value when value == Ranking.FormRankingByGender:
                    LoadFormForRankingByGender();
                    break;
            }
        }

        //
        public void LoadFormForRankingByGender()
        {
            // 
            RankingTitle.Text = "Classer par sexe";
            RankingTypeOneTitle.Text = Gender.Femme.ToString();
            RankingTypeTwoTitle.Text = Gender.Homme.ToString();
            //
            ListView FemmalesPatientsListView = RankingTypeOneList;
            ListView MensPatientsListView = RankingTypeTwoList;

            InitializeListViewByGender(FemmalesPatientsListView);
            InitializeListViewByGender(MensPatientsListView);


            foreach (var patientRecord in Cabinet.Patients)
            {
                if(patientRecord.Sexe == Gender.Femme)
                    FemmalesPatientsListView.Items.Add(FillListViewItemByGender(patientRecord));
                else
                    MensPatientsListView.Items.Add(FillListViewItemByGender(patientRecord));
                
            }


        }
        private ListViewItem FillListViewItemByGender(Patient patientRecord)
        {
            ListViewItem item = new ListViewItem(patientRecord.Nom);
            item.SubItems.Add(patientRecord.Prenom);
            item.SubItems.Add(patientRecord.DateNaissance.ToString());
            item.Tag = patientRecord.Id;  
            return item;
       
        }
        private void InitializeListViewByGender(ListView listView)
        {

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("Nom", 100);
            listView.Columns.Add("Prenom", 100);
            listView.Columns.Add("Date de naissance,", 100);

            listView.View = View.Details;
            listView.FullRowSelect = true;
        }

        //
        public void LoadFormForRankingByAge()
        {
            RankingTitle.Text = "Classer par âge";
            RankingTypeOneTitle.Text = "Adulte";
            RankingTypeTwoTitle.Text = "Enfant";

            ListView AdulesPatientsListView = RankingTypeOneList;
            ListView KidsPatientsListView = RankingTypeTwoList;
            InitializeListViewByAge(AdulesPatientsListView);
            InitializeListViewByAge(KidsPatientsListView);


            foreach (var patientRecord in Cabinet.Patients)
            {
                if (patientRecord.Age() >= 18)
                    AdulesPatientsListView.Items.Add(FillListViewItemByAge(patientRecord));
                else
                    KidsPatientsListView.Items.Add(FillListViewItemByAge(patientRecord));

            }

        }

        private ListViewItem FillListViewItemByAge(Patient patientRecord)
        {
            ListViewItem item = new ListViewItem(patientRecord.Nom);
            item.SubItems.Add(patientRecord.Prenom);
            item.SubItems.Add(patientRecord.Age().ToString());
            item.Tag = patientRecord.Id;
            return item;

        }






        private void InitializeListViewByAge(ListView listView)
        {

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("Nom", 100);
            listView.Columns.Add("Prenom", 100);
            listView.Columns.Add("Age", 100);
            listView.Columns.Add("Sexe", 100);
           

            listView.View = View.Details;
            listView.FullRowSelect = true;
        }
    }
}
