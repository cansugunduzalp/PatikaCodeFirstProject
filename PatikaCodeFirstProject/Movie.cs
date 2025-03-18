using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirstProject
{
    public class Movie
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }

        [Required] // Boş geçilemez
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        public int ReleaseYear { get; set; }
    }
}
