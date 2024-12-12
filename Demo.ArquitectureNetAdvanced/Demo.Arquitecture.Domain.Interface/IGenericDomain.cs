using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Domain.Interface
{
    public interface IGenericDomain<T> where T : class
    {
        Task<T> Add(T obj);
        Task<T> Update(T obj, int id);
        Task<bool> Delete(int id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
