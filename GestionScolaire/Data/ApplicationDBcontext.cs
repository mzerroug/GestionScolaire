using GestionScolaire.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionScolaire.Data
{
    public class ApplicationDBContext : DbContext
    {
        // we will pass database options in this parametter

        // this is a general setup to do

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        // set the model in the DBContext 
        public DbSet<Eleve> eleves { get; set; }

       public DbSet<Matiere>  matieres { get; set; }
       
        public DbSet<Professeur> professeurs { get; set; }

    }
}
