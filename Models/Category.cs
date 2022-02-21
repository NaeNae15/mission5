using System;
using System.ComponentModel.DataAnnotations;

namespace JoelHilton.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
