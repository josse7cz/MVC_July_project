using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_July_project.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
       
        [RegularExpression(@"^[A-Ž]+[a-žA-Ž\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }


        [Range(1, 1000)]
       // [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
       
        public string Rating { get; set; }
    }
}
