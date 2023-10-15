using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace VideoGameList.Models
{
    public class videoGameContext : DbContext
    {
        public videoGameContext()
        {

        }
        public videoGameContext(DbContextOptions<videoGameContext> options)
            : base(options) { }


        public DbSet<videoGame> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<videoGame>().HasData(
            new videoGame
            {
                videoGameId = 1,
                name = "Castlevania Symphony of the Night",
                favoriteCharacter = "alucard",
                wouldPlayAgain = true
            },
             new videoGame
             {
                 videoGameId = 1,
                 name = "Factorio",
                 favoriteCharacter = "player",
                 wouldPlayAgain = true
             },
             new videoGame
             {
                 videoGameId = 1,
                 name = "satisfactory",
                 favoriteCharacter = "Protagonist",
                 wouldPlayAgain = true
             }
            ); ;
        }
    }
}
