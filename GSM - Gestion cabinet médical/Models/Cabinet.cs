using GSM___Gestion_cabinet_médical.Enums;
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
        public List<Speciality> Specialites { get; set; }
        public static List<Patient> Patients { get; set; } = new List<Patient>();




        public Cabinet()
        {
        }

        public Cabinet(string nom, string adresse, List<Speciality> specialites, List<Patient> patients)
        {
            Nom = nom;
            Adresse = adresse;
            Specialites = specialites;
            Patients = patients;
        }



        public static void AjouterPatient(Patient patient) => Patients.Add(patient);

        public static void SupprimerPatient(Patient patient) => Patients.Remove(patient);

        public static Patient ChercherPatient(string nom) => Patients.FirstOrDefault(p => p.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));
        public static Patient findPationById(int id) => Patients.FirstOrDefault(p => p.Id == id);

        public static List<Patient> PatientsParSexe(Gender sexe) => Patients.Where(p => p.Sexe == sexe).ToList();

        public static List<Patient> PatientsParSpecialite(Speciality specialite) => Patients.Where(p => p.SpecialiteDemandee == specialite).ToList();

        public static Patient PatientPrioritaire() => Patients.FirstOrDefault();

        public static List<IGrouping<string, Patient>> PatientsParAge()
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
