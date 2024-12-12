using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Infraestructure.Data;
using Demo.Arquitecture.Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Core
{
    public class PurchaseDetailsDomain : IPurchaseDetailsDomain
    {

        private readonly IRepository<PurchaseDetail> _repository;
        private readonly CustomDataContext _customDataContext;

        public PurchaseDetailsDomain(IRepository<PurchaseDetail> repository, CustomDataContext customDataContext)
        {
            _repository = repository;
            _customDataContext = customDataContext;
        }

        public async Task<PurchaseDetail> Add(PurchaseDetail obj)
        {
            return await _repository.Add(obj);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PurchaseDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<PurchaseDetail>> GetAllPurchases()
        {
            //var detailsShoopings = await (from purchaseDetails in _customDataContext.PurchaseDetails
            //                              join product in _customDataContext.Products on purchaseDetails.ProductId equals product.ProductId
            //                              join shooping in _customDataContext.Shoopings on purchaseDetails.ShoopingId equals shooping.ShoopingId
            //                              select new
            //                              {
            //                                  Id = purchaseDetails.PurchaseDetailId,
            //                                  ProductId = purchaseDetails.ProductId,
            //                                  ShoopingId = purchaseDetails.ShoopingId,
            //                                  Quantity = purchaseDetails.Quantity,
            //                                  Price = purchaseDetails.Price

            //                              }).ToListAsync();

            return await _customDataContext.PurchaseDetails.ToListAsync();
        }

        public Task<PurchaseDetail> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PurchaseDetail> GetPurchaseById(int id)
        {
            return await _repository.GetById(id);
        }

        public Task<PurchaseDetail> Update(PurchaseDetail obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
