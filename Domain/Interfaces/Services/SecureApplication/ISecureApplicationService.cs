using BHDSeguros.Domain.DTOs.SecureApplications;
using BHDSeguros.Domain.Entities.SecureApplications;

namespace 
    BHDSeguros.Domain.Interfaces.Services.SecureApplication
{
    public interface ISecureApplicationService
    {
        string Create(SecureApplicationsDto secure);
    }
}
