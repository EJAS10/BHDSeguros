using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.Infrastructure.Repository.SecureApplication
{
    public class ProductTypeRepository : RepositoryBase<ProductTypeEntitie, DataBaseContext>, IProductTypeRepository
    {

        private readonly DataBaseContext _context;
        public ProductTypeRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }

        public ProductTypeEntitie? GetByName(string Name)
        {
            return _context.Set<ProductTypeEntitie>()
               .Where(x => x.ProductTypeName.Equals(Name)).FirstOrDefault();
        }
    }
}