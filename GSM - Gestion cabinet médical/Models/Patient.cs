﻿using GSM___Gestion_cabinet_médical.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Patient : Model
    {
        
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public Gender Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public Speciality SpecialiteDemandee { get; set; }

        public Patient() { }

        public Patient(string nom, string prenom, string adresse, Gender sexe, DateTime dateNaissance, Speciality specialiteDemandee)
        {
            Id = GenerateTimeBasedId();

            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Sexe = sexe;
            DateNaissance = dateNaissance;
            SpecialiteDemandee = specialiteDemandee;
        }

        public override string ToString()
        {
            return $"{Id}, {Nom} {Prenom} - {SpecialiteDemandee}";
        }

      

        public int Age()
        {
           return DateTime.Now.Year - DateNaissance.Year;
        }

    }
}
