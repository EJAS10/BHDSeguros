using AutoMapper;
using BHDSeguros.Domain.DTOs.SecureApplications;
using BHDSeguros.Domain.Entities.Client;

namespace BHDSeguros.Domain.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<SecureApplicationsDto, ClientEntitie>();

            CreateMap<ClientSecureEntitie, ClientSecurePlansDto>()
                .ForMember(d => d.SecureType, o => o.MapFrom(s => s.SecurePlans.SecureCode.SecureCode))
                .ForMember(d => d.PlanFee, o => o.MapFrom(s => s.SecurePlans.PlanFee))
                .ForMember(d => d.SecurePlan, o => o.MapFrom(s => s.SecurePlans.PlansName))
                .ForMember(d => d.TypeProduct, o => o.MapFrom(s => s.ProductType.ProductTypeName))
                .ForMember(d => d.DateSell, o => o.MapFrom(s => s.DateCreation))
                .ForMember(d => d.SecureNumber, o => o.MapFrom(s => s.Policy));
        }
    }
}
