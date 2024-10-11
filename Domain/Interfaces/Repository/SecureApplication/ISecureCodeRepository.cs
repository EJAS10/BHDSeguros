using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Repository.SecureApplication
{
    public interface ISecureCodeRepository
    {
     
        void Create(SecureCodeEntitie entity);
    }
}
