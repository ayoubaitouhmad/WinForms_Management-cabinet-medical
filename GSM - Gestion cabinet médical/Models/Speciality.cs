using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Speciality : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Speciality> DefaultSpecs = new List<Speciality>
        {
            new Speciality( "généraliste"),new Speciality("dentiste"),new Speciality("cardiologue")
        };




        public Speciality( string nom)
        {
            Id = GenerateTimeBasedId();
            Name = nom;
        }


       

    }
}
