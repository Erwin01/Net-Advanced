using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Entity
{
    public class Shooping
    {
        [Key]
        public int ShoopingId { get; set; }
        [Display(Name = "ClientId")]
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        [Display(Name = "ShoopingDate")]
        public DateTime ShoopingDate { get; set; }
    }
}
