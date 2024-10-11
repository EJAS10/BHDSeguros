using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Repository.SecureApplication
{
    public interface ISecurePlansRepository
    {
        SecurePlansEntitie? GetByCode(string code);      
        void Create(SecurePlansEntitie entity);
    }
}
