﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime CreatedAt { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int Stock { get; set; }  
    }
}