using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Core
{
    public class PetDomain : IPetDomain
    {
        private readonly IRepository<Pet> _repository;

        public PetDomain(IRepository<Pet> repository)
        {
            _repository = repository;
        }


        public async Task<Pet> Add(Pet obj)
        {
            return await _repository.Add(obj);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pet>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pet> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pet> Update(Pet obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
