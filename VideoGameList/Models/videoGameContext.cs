
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


        public DbSet<videoGame> videoGames { get; set; }
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
                 videoGameId = 2,
                 name = "Factorio",
                 favoriteCharacter = "Protagonist",
                 wouldPlayAgain = true
             },
             new videoGame
             {
                 videoGameId = 3,
                 name = "satisfactory",
                 favoriteCharacter = "Protagonist",
                 wouldPlayAgain = true
             }
            ); ;
        }
    }
}
