using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace GestionScolaire.Models
{
    public class Eleve
    {
        [Key]
        public int CNE { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance {get; set; }
        public String Sexe { get; set; }
        public int Telephone { get; set; }
        public String Email { get; set; }
        public String  Adresse { get; set; }
        public String ChoixFiliere { get; set; }
        public int NiveauEtude { get; set; }
    }
}
