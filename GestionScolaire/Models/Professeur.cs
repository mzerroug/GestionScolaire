using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionScolaire.Models
{
    public class Professeur
    {
        [Key]
        public int CIN { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public String Sexe { get; set; }

        [ForeignKey("MatiereEnseigne")]
        public int MatiereEnseigne { get; set; }

        public int Telephone { get; set; }
        public String Email { get; set; }



    }
}
