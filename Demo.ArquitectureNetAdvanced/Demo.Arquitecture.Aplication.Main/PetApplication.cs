using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Aplication.Interface;
using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Domain.Interface;
using Demo.Arquitecture.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.Main
{
    public class PetApplication : IPetApplication
    {

        private readonly IPetDomain _petDomain;

        public PetApplication(IPetDomain petDomain)
        {
            _petDomain = petDomain;
        }

        public async Task<Response<PetDTO>> AddAsync(PetDTO obj)
        {
            try
            {
                var map = AutoMapp<PetDTO, Pet>.Convert(obj);
                var addPet = await _petDomain.Add(map);
                obj.Id = addPet.Id;

                return Response<PetDTO>.Success(obj, "Success", true);

            }
            catch (Exception ex)
            {
                return Response<PetDTO>.Error(null, ex, ex.Message, false);
            }
        }

        public Task<Response<bool>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<PetDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<PetDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<PetDTO>> UpdateAsync(PetDTO obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
