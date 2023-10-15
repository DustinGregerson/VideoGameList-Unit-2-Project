using System.ComponentModel.DataAnnotations;
namespace VideoGameList.Models
{
    public class videoGame
    {
        public int videoGameId { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string? name { get; set; }
        [Required(ErrorMessage = "Please enter favorite character.")]
        public string? favoriteCharacter { get; set; }
        [Required(ErrorMessage = "Please enter favorite character.")]
        public bool? wouldPlayAgain { get; set; }
        [Required(ErrorMessage = "Please enter yes or no.")]

    }
}
