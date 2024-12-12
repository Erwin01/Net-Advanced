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
    public class ProductApplication : IProductApplication
    {

        private readonly IProductDomain _repository;

        public ProductApplication(IProductDomain repository)
        {
            _repository = repository;
        }

        public async Task<Response<ProductDTO>> AddAsync(ProductDTO obj)
        {
            try
            {
                var map = AutoMapp<ProductDTO, Product>.Convert(obj);
                var addProduct = await _repository.Add(map);

                return Response<ProductDTO>.Success(obj, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ProductDTO>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<bool>> DeleteAsync(int id)
        {
            try
            {
                var getProductId = await _repository.GetById(id);

                if (getProductId == null)
                {
                   return Response<bool>.Error(false, null, "No record found against this Id", false);
                }
                else
                {
                    await _repository.Delete(id);

                    return Response<bool>.Success(true, "Success", true);
                }
            }
            catch (Exception ex)
            {
                return Response<bool>.Error(false, ex, ex.Message, false);
            }
        }

        public async Task<Response<List<ProductDTO>>> GetAllAsync()
        {
            try
            {
                var listData = await _repository.GetAll();
                var autoMapp = AutoMapp<Product, ProductDTO>.ConvertList2(listData);

                return Response<List<ProductDTO>>.Success(autoMapp, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<List<ProductDTO>>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<ProductDTO>> GetByIdAsync(int id)
        {
            try
            {
                var productById = await _repository.GetById(id);
                var autoMapp = AutoMapp<Product, ProductDTO>.Convert(productById);

                if (productById == null)
                {
                    return Response<ProductDTO>.Error(autoMapp, null, "No record found against this Id", false);
                }
                else
                {
                    return Response<ProductDTO>.Success(autoMapp, "Success", true);
                }
            }
            catch (Exception ex)
            {
                return Response<ProductDTO>.Error(null, null, ex.Message, false);
            }
        }

        public async Task<Response<ProductDTO>> UpdateAsync(ProductDTO obj, int id)
        {
            try
            {
                var autoMapp = AutoMapp<ProductDTO, Product>.Convert(obj);
                var addProduct = await _repository.Update(autoMapp, id);

                return Response<ProductDTO>.Success(obj, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ProductDTO>.Error(null, ex, ex.Message, false);
            }
        }
    }
}
