using System.ComponentModel.DataAnnotations;

namespace Practica.EF.MVC.Models
{
    public class SuppliersViewModel
    {
        public int SupplierId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [StringLength(15)]
        public string City { get; set; }
        [StringLength(15)]
        public string Country { get; set; }
        public string Phone { get; set; } 
        public string ContactName { get; set; }
    }
}