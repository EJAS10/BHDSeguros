using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.Infrastructure.Repository.SecureApplication
{
    public class AllowedProductTypeRepository : RepositoryBase<ProductTypeEntitie, DataBaseContext>, IAllowedProductTypeRepository
    {

        private readonly DataBaseContext _context;
        public AllowedProductTypeRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }

        public ProductTypeEntitie? GetByName(string Name)
        {
            return _context.Set<ProductTypeEntitie>()
               .Where(x => x.ProductTypeName == Name).FirstOrDefault();
        }
    }
}