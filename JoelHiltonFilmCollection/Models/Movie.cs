
using System.ComponentModel.DataAnnotations;

namespace Mission6_Cruz.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown (G, PG, PG-13, R)

        public bool? Edited { get; set; } // Optional Yes/No

        public string? LentTo { get; set; } // Optional

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional, max 25 chars
    }
}