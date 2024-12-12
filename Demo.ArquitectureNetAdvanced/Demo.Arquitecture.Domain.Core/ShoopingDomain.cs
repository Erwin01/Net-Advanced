using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Infraestructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Core
{
    public class ShoopingDomain : IShoopingDomain
    {

        private readonly IRepository<Shooping> _repository;

        public ShoopingDomain(IRepository<Shooping> repository)
        {
            _repository = repository;
        }

        public async Task<Shooping> Add(Shooping obj)
        {
            return await _repository.Add(obj); 
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<Shooping>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Shooping> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Shooping> Update(Shooping obj, int id)
        {
            return await _repository.Update(obj, id);
        }
    }
}
