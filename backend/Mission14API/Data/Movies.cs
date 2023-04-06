using System.ComponentModel.DataAnnotations;

namespace Mission14API.Data
{
    public class Movies
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Year { get; set; }

        [Required]
        public string? Director { get; set; }

        [Required]
        public string? Rating { get; set; }

        public bool Edited { get; set; }

        public string? Lent { get; set; }

        public string? Notes { get; set; }


    }
}
