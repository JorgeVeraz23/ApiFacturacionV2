using WebApplication9.Models.Dto;
using WebApplication9.Repository;
using WebApplication9.Models.Dto;
using AutoMapper;
using WebApplication9.Models;
using WebApplication9.Models.Dto.VentaDto;
namespace WebApplication9 { 




    public class MappingConfig : Profile
    {
        public MappingConfig() { 
            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<Venta, CreateVentaDto>().ReverseMap();
            CreateMap<Venta, UpdateVentaDto>().ReverseMap();
        }
    }
}
