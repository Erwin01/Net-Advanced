using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Arquitecture.Domain.Entity
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }
    }
}
