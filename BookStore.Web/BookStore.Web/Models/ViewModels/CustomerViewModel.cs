using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Web.Models.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Vardas")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Pavardė")]
        public string LastName { get; set; }
    }
}