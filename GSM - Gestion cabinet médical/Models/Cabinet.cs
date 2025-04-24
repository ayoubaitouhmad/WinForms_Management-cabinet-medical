using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Cabinet
    {
    

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<string> Specialites { get; set; } = new List<string> { "Généraliste", "Dentiste", "Cardiologue" };
        public List<Patient> Patients { get; set; } = new List<Patient>();



        public Cabinet()
        {
        }

        public Cabinet(string nom, string adresse, List<string> specialites, List<Patient> patients)
        {
            Nom = nom;
            Adresse = adresse;
            Specialites = specialites;
            Patients = patients;
        }



        public void AjouterPatient(Patient patient) => Patients.Add(patient);

        public void SupprimerPatient(Patient patient) => Patients.Remove(patient);

        public Patient ChercherPatient(string nom) => Patients.FirstOrDefault(p => p.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));

        public List<Patient> PatientsParSexe(string sexe) => Patients.Where(p => p.Sexe == sexe).ToList();

        public List<Patient> PatientsParSpecialite(string specialite) => Patients.Where(p => p.SpecialiteDemandee == specialite).ToList();

        public Patient PatientPrioritaire() => Patients.FirstOrDefault();

        public List<IGrouping<string, Patient>> PatientsParAge()
        {
            return Patients.GroupBy(p =>
            {
                int age = DateTime.Now.Year - p.DateNaissance.Year;
                if (age < 18) return "Enfant";
                if (age < 60) return "Adulte";
                return "Senior";
            }).ToList();
        }
    }
}
