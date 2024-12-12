using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Infraestructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Core
{
    public class ProductDomain : IProductDomain
    {

        private readonly IRepository<Product> _repository;

        public ProductDomain(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Product> Add(Product obj)
        {
            return await _repository.Add(obj);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Product> Update(Product obj, int id)
        {
            return await _repository.Update(obj, id);
        }
    }
}
