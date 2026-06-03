using System.ComponentModel.DataAnnotations;

namespace NBAApi.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Team { get; set; }

        [Range(0, 99)]
        public int Number { get; set; }
    }
}