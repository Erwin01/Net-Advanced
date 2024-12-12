using Demo.Arquitecture.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Interface
{
    public interface IPurchaseDetailsDomain : IGenericDomain<PurchaseDetail>
    {
        Task<List<PurchaseDetail>> GetAllPurchases();
        Task<PurchaseDetail> GetPurchaseById(int id);
    }
}
