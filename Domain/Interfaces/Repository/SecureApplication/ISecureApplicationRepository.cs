using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Repository.SecureApplication
{
    public interface ISecureApplicationRepository
    {
        void Create(SecureApplicationsEntitie entity);
    }
}
