using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Arquitecture.Domain.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Display(Name = "Stock")]
        public int Stock { get; set; }
    }
}
