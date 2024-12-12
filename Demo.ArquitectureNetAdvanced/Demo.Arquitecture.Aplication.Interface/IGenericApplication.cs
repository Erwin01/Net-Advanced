using Demo.Arquitecture.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.Interface
{
    public interface IGenericApplication<T> where T : class
    {
        Task<Response<T>> AddAsync(T obj);
        Task<Response<T>> UpdateAsync(T obj, int id);
        Task<Response<bool>> DeleteAsync(int id);
        Task<Response<List<T>>> GetAllAsync();
        Task<Response<T>> GetByIdAsync(int id);
    }
}
