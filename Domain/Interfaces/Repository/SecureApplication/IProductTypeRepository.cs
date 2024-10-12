using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Interfaces.Repository.SecureApplication
{
    public interface IProductTypeRepository
    {
        ProductTypeEntitie? GetByName(string Name);
    }
}
