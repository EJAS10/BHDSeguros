using BHDSeguros.Domain.DTOs.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Services.SecureApplication
{
    public interface ISecureApplicationService
    {
        List<ClientSecurePlansDto> GetClientSecurePlans(string Identification);
        string Create(SecureApplicationsDto secure);
    }
}
