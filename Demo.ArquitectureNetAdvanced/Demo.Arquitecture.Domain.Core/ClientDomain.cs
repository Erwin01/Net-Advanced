using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Infraestructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Core
{
    public class ClientDomain : IClientDomain
    {

        private readonly IRepository<Client> _repository;

        public ClientDomain(IRepository<Client> repository)
        {
            _repository = repository;
        }

        public async Task<Client> Add(Client obj)
        {
            return await _repository.Add(obj);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<Client>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Client> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<Client> Update(Client obj, int id)
        {
            return await _repository.Update(obj, id);
        }
    }
}
