using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Aplication.Interface;
using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.Main
{
    public class PurchaseDetailsApplication : IPurchaseDetailsApplication
    {

        private readonly IPurchaseDetailsDomain _repository;

        public PurchaseDetailsApplication(IPurchaseDetailsDomain repository)
        {
            _repository = repository;
        }


        public async Task<Response<PurchaseDetailDTO>> AddAsync(PurchaseDetailDTO obj)
        {
            try
            {
                PurchaseDetail ObjSave = new PurchaseDetail();

                ObjSave.PurchaseDetailId = obj.PurchaseDetailId;
                ObjSave.ProductId = obj.ProductId;
                ObjSave.ShoopingId = obj.ShoopingId;
                ObjSave.Price = obj.Price;
                ObjSave.Quantity = obj.Quantity;

                ObjSave.Purchases = AutoMapp<PurchaseDTO, Purchase>.ConvertList2(obj.PurchasesDetails);

                var add = await _repository.Add(ObjSave);

                return Response<PurchaseDetailDTO>.Success(null, "Successfull", true);
            }
            catch (Exception ex)
            {
                return Response<PurchaseDetailDTO>.Success(null, ex.Message, false);
            }
        }

        public Task<Response<bool>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<PurchaseDetailDTO>>> GetAllAsync()
        {
            try
            {
                var listDetailData = await _repository.GetAllPurchases();
                var listResponseData = new List<PurchaseDetailDTO>();

                foreach (var obj in listDetailData)
                {
                    var ObjSave = new PurchaseDetailDTO();

                    ObjSave.PurchaseDetailId = obj.PurchaseDetailId;
                    ObjSave.ProductId = obj.ProductId;
                    ObjSave.ShoopingId = obj.ShoopingId;
                    ObjSave.Quantity = obj.Quantity;
                    ObjSave.Price = obj.Price;

                    ObjSave.PurchasesDetails = AutoMapp<Purchase, PurchaseDTO>.ConvertList2(obj.Purchases);
                    listResponseData.Add(ObjSave);
                }

                return Response<List<PurchaseDetailDTO>>.Success(listResponseData, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<List<PurchaseDetailDTO>>.Success(null, ex.Message, false);
            }
        }

        public async Task<Response<PurchaseDetailDTO>> GetByIdAsync(int id)
        {
            try
            {
                var purchaseById = await _repository.GetPurchaseById(id);

                if (purchaseById == null)
                {
                    return Response<PurchaseDetailDTO>.Error(null, null, "No record found against this Id", false);
                }
                else
                {
                    PurchaseDetailDTO ObjSave = new PurchaseDetailDTO();

                    ObjSave.PurchaseDetailId = purchaseById.PurchaseDetailId;
                    ObjSave.ProductId = purchaseById.ProductId;
                    ObjSave.ShoopingId = purchaseById.ShoopingId;
                    ObjSave.Quantity = purchaseById.Quantity;
                    ObjSave.Price = purchaseById.Price;

                    ObjSave.PurchasesDetails = AutoMapp<Purchase, PurchaseDTO>.ConvertList2(purchaseById.Purchases);

                    return Response<PurchaseDetailDTO>.Success(ObjSave, "Success", true);

                }
            }
            catch (Exception ex)
            {
                return Response<PurchaseDetailDTO>.Success(null, ex.Message, false);
            }
        }

        public Task<Response<PurchaseDetailDTO>> UpdateAsync(PurchaseDetailDTO obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
