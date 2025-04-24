using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public string SpecialiteDemandee { get; set; }

        public Patient() { }

        public Patient(string nom, string prenom, string adresse, string sexe, DateTime dateNaissance, string specialiteDemandee)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Sexe = sexe;
            DateNaissance = dateNaissance;
            SpecialiteDemandee = specialiteDemandee;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} - {SpecialiteDemandee}";
        }
    }
}
