using AutoMapper;
using System.Collections.Generic;

namespace Demo.Arquitecture.Transversal.Common
{
    public class AutoMapp<T, T2>
    {

        public static T2 Convert(T obj)
        {
            var configuration = new MapperConfiguration(conf =>
            {
                conf.CreateMap<T, T2>();
            });

            Mapper mapper = new Mapper(configuration);
            IMapper iMapper = configuration.CreateMapper();

            return iMapper.Map<T, T2>(obj);
        }


        public static IEnumerable<T2> ConvertList(IEnumerable<T> obj)
        {
            var configuration = new MapperConfiguration(conf =>
            {
                conf.CreateMap<T, T2>();
            });

            Mapper mapper = new Mapper(configuration);
            IMapper iMapper = configuration.CreateMapper();

            return iMapper.Map<IEnumerable<T>, IEnumerable<T2>>(obj);
        }


        public static List<T2> ConvertList2(List<T> obj)
        {
            var configuration = new MapperConfiguration(conf =>
            {
                conf.CreateMap<T, T2>();
            });

            Mapper mapper = new Mapper(configuration);
            IMapper iMapper = configuration.CreateMapper();

            return iMapper.Map<List<T>, List<T2>>(obj);
        }

    }
}
