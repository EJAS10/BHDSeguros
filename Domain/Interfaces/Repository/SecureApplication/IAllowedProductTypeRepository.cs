using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Repository.SecureApplication
{
    public interface IAllowedProductTypeRepository
    {
        ProductTypeEntitie? GetByName(string Name);
    }
}
