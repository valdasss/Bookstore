using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.Models.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Knygos pavadinimas")]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        [Display(Name = "Knygos išleidimo data")]
        public DateTime PublishDate { get; set; }
    }
}