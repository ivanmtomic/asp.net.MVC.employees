using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Address { get; set; }

        [Display(Name = "Netto sallary")]
        public decimal NettoSallary { get; set; }
        
        [Display(Name = "Brutto sallary")]
        public decimal BruttoSallary { get; set; }

        public decimal tax1 { get; set;}
        public decimal tax2 { get; set;}
        public decimal tax3 { get; set;}
        public decimal tax4 { get; set;}
        
    }
}