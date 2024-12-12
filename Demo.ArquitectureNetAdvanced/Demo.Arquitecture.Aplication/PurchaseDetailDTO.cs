using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.DTO
{
    public class PurchaseDetailDTO
    {
        
        public int PurchaseDetailId { get; set; }
        public int ProductId { get; set; }
        public int ShoopingId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public List<PurchaseDTO> PurchasesDetails { get; set; }

    }
}
