using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.EF.WebAPI.Models
{
    public class SpellViewModel
    {
        public int id { get; set; }
        public string hechizo { get; set; }
        public string uso { get; set; }
    }
}