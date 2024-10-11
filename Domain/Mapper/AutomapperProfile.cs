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
        }
    }
}
