using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM___Gestion_cabinet_médical.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Speciality> DefaultSpecs = new List<Speciality>
        {
            new Speciality(1, "généraliste"),new Speciality(1, "dentiste"),new Speciality(1, "cardiologue")
        };




        public Speciality(int id, string nom)
        {
            id = id;
            Name= nom;
        }


       

    }
}
