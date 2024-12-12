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
    public class ShoopingApplication : IShoopingApplication
    {

        private readonly IShoopingDomain _shoopingDomain;

        public ShoopingApplication(IShoopingDomain shoopingDomain)
        {
            _shoopingDomain = shoopingDomain;
        }

        public async Task<Response<ShoopingDTO>> AddAsync(ShoopingDTO obj)
        {
            try
            {
                var map = AutoMapp<ShoopingDTO, Shooping>.Convert(obj);
                var addShooping = await _shoopingDomain.Add(map);

                return Response<ShoopingDTO>.Success(obj, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ShoopingDTO>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<bool>> DeleteAsync(int id)
        {
            try
            {
                var getShoopingId = await _shoopingDomain.GetById(id);

                if (getShoopingId == null)
                {
                    return Response<bool>.Error(false, null, "No record found against this Id", false);
                }
                else
                {
                    await _shoopingDomain.Delete(id);

                    return Response<bool>.Success(true, "Success", true);
                }
            }
            catch (Exception ex)
            {
                return Response<bool>.Error(false, ex, ex.Message, false);
            }
        }

        public async Task<Response<List<ShoopingDTO>>> GetAllAsync()
        {
            try
            {
                var listData = await _shoopingDomain.GetAll();
                var autoMapp = AutoMapp<Shooping, ShoopingDTO>.ConvertList2(listData);

                return Response<List<ShoopingDTO>>.Success(autoMapp, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<List<ShoopingDTO>>.Error(null, ex, ex.Message, false);
            }
        }

        public async Task<Response<ShoopingDTO>> GetByIdAsync(int id)
        {
            try
            {
                var data = await _shoopingDomain.GetById(id);
                var autoMapp = AutoMapp<Shooping, ShoopingDTO>.Convert(data);

                return Response<ShoopingDTO>.Success(autoMapp, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ShoopingDTO>.Success(null, ex.Message, false);
            }
        }

        public async Task<Response<ShoopingDTO>> UpdateAsync(ShoopingDTO obj, int id)
        {
            try
            {
                var data = AutoMapp<ShoopingDTO, Shooping>.Convert(obj);
                var addShooping = await _shoopingDomain.Update(data, id);

                return Response<ShoopingDTO>.Success(obj, "Success", true);
            }
            catch (Exception ex)
            {
                return Response<ShoopingDTO>.Error(null, ex, ex.Message, false);
            }
        }
    }
}
