using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab06.Models
{
    public class Review
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must have at least 2 characters")]
        [Required]
        public string Reviewer { get; set; }

        [StringLength(120, MinimumLength = 20, ErrorMessage = "Your review must have at least 20 characters.")]
        [Required]
        public string userReview { get; set; }

        [Required]
        public int movieID { get; set; }

    }
}
