using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica.EF.MVC.Models
{
    public class SuppliersViewModel
    {
        public int SupplierId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [StringLength(15, ErrorMessage = "Error")]
        public string City { get; set; }
        [StringLength(15)]
        public string Country { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }
    }
}