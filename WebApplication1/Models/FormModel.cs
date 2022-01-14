using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FormModel
    {
     [Display(Name = "Imię")]
     public string Name { get; set; }
     [Display(Name = "Data Urodzenia")]
     public DateTime DataUrodzenia { get; set; }
    }
}
