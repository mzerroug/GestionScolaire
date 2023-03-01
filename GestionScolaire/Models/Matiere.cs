using System.ComponentModel.DataAnnotations;

namespace GestionScolaire.Models
{
    public class Matiere
    {
        [Key]
        public int Id { get; set; }
        
        public String NomMatiere { get; set; }
        public int NbrMatiere { get; set; }
    }
}
