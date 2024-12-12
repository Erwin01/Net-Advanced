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
    public class ClientApplication : IClientApplication
    {

        private readonly IClientDomain _clientDomain;

        public ClientApplication()
        {
        }

        public ClientApplication(IClientDomain clientDomain)
        {
            _clientDomain = clientDomain;
        }

        public async Task<Response<ClientDTO>> AddAsync(ClientDTO obj)
        {
            try
            {
                var map = AutoMapp<ClientDTO, Client>.Convert(obj);
                var addClient = await _clientDomain.Add(map);
                obj.ClientId = addClient.ClientId;

                return Response<ClientDTO>.Success(obj, "Success", true);
                
            }
            catch (Exception ex)
            {
                return Response<ClientDTO>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<bool>> DeleteAsync(int id)
        {
            try
            {
                var getClientId = await _clientDomain.GetById(id);

                if (getClientId == null)
                {
                    return Response<bool>.Error(false, null, "No record found against this Id", false);
                }
                else
                {
                    await _clientDomain.Delete(id);

                    return Response<bool>.Success(true, "Success", true);
                }
            }
            catch (Exception ex)
            {
                return Response<bool>.Error(false, ex, ex.Message, false);
            }
        }

        public async Task<Response<List<ClientDTO>>> GetAllAsync()
        {
            try
            {
                var listData = await _clientDomain.GetAll();
                var autoMapp = AutoMapp<Client, ClientDTO>.ConvertList2(listData);

                return Response<List<ClientDTO>>.Success(autoMapp, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<List<ClientDTO>>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<ClientDTO>> GetByIdAsync(int id)
        {
            try
            {
                var clienById = await _clientDomain.GetById(id);
                var autoMapp = AutoMapp<Client, ClientDTO>.Convert(clienById);

                if (clienById == null)
                {
                    return Response<ClientDTO>.Error(autoMapp, null, "No record found against this Id", false);
                }
                else
                {
                    return Response<ClientDTO>.Success(autoMapp, "Success", true);
                }
            }
            catch (Exception ex)
            {
                return Response<ClientDTO>.Error(null, null, ex.Message, false);
            }
        }

        public async Task<Response<ClientDTO>> UpdateAsync(ClientDTO obj, int id)
        {
            try
            {
                var data = AutoMapp<ClientDTO, Client>.Convert(obj);
                var addClient = await _clientDomain.Update(data, id);

                return Response<ClientDTO>.Success(obj, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ClientDTO>.Error(null, ex, ex.Message, false);
            }
        }
    }
}
