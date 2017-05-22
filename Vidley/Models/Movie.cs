using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidley.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
      
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Movie Genre")]        
        public Genre GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

               
        public DateTime DateAdded { get; set; }

        [Required]
        [StockBetween1And20]        
        [Display(Name = "Number In Stock")]        
        public int NumberInStock { get; set; }

    }
}
