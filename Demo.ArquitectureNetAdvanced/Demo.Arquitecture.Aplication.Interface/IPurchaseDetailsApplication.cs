using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.Interface
{
    public interface IPurchaseDetailsApplication : IGenericApplication<PurchaseDetailDTO>
    {
        //Task<Response<List<PurchaseDetailsDTO>>> GetAllPurchaseDetailAsync();
    }
}
