using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models
{
    public class MovieResponses { 

        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please include the title of the Movie.")]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }


        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
