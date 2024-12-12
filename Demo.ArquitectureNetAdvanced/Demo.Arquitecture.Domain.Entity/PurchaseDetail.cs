using Demo.Arquitecture.Aplication.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Entity
{
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseDetailId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("ShoopingId")]
        public int ShoopingId { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        
        public List<Purchase> Purchases { get; set; }
    }
}
