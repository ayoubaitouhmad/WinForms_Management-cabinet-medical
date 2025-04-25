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

namespace GSM___Gestion_cabinet_médical.Forms
{
    public partial class FirstPatient : BaseForm
    {
        public FirstPatient()
        {
            InitializeComponent();
            textboxStyling(tbFirstName);
            textboxStyling(tbLastName);
            textboxStyling(tbGender);
            textboxStyling(tbSpec);


            tbFirstName.ReadOnly= true;
            tbLastName.ReadOnly = true;
            tbGender.ReadOnly = true;
            tbSpec.ReadOnly = true;
        }

        private void FirstPatient_Load(object sender, EventArgs e)
        {
            Patient patient = Cabinet.PatientPrioritaire();
            tbFirstName.Text = patient.Nom;
            tbLastName.Text = patient.Prenom;
            tbGender.Text = patient.Sexe.ToString();
            tbSpec.Text = patient.SpecialiteDemandee.Name;



        }
    }
}
