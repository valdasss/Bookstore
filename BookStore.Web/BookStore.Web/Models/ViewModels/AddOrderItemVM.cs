using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Web.Models.ViewModels
{
    public class AddOrderItemVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Knygos pavadinimas")]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        [Display(Name = "Knygos išleidimo data")]
        public DateTime PublishDate { get; set; }
        public int Quantity { get; set; }
    }
}