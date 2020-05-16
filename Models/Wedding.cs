using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        
        [Display(Name="Wedder One")]
        [Required(ErrorMessage = "Must enter Wedder's Name")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string WedderOne { get; set; }

        [Display(Name="Wedder Two")]
        [Required(ErrorMessage = "Takes two people to get married buddy")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string WedderTwo { get; set; }

        [Required]
        public DateTime Date {get;set;}

        [Required(ErrorMessage = "Must enter address of Wedding")]
        public string Address {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Guest> Attendees {get;set;}
    }

}