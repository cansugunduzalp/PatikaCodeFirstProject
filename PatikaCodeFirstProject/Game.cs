using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirstProject
{
    public class Game
    {
        [Key] // Birincil anahtar
        public int Id { get; set; }

        [Required] // Boş geçilemez
        public string Name { get; set; }

        [Required]
        public string Platform { get; set; }

        [Range(0, 10)] // 0 ile 10 arasında bir değer olmalı
        public decimal Rating { get; set; }
    }
}
