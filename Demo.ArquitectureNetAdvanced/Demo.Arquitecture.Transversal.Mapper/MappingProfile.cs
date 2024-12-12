using AutoMapper;
using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Domain.Entity;

namespace Demo.Arquitecture.Transversal.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Shooping, ShoopingDTO>().ReverseMap();
            CreateMap<PurchaseDetail, PurchaseDetailDTO>().ReverseMap();
            CreateMap<Purchase, PurchaseDTO>().ReverseMap();

            CreateMap<Pet, PurchaseDTO>().ReverseMap();
        }
    }
}
