using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.Infrastructure.Repository.SecureApplication
{
    public class SecurePlansRepository : RepositoryBase<SecurePlansEntitie, DataBaseContext>, ISecurePlansRepository
    {

        private readonly DataBaseContext _context;
        public SecurePlansRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }
        public SecurePlansEntitie? GetByCode(string code)
        {
            return _context.Set<SecurePlansEntitie>()
                .Include(x => x.SecureCode)
                .Include(y => y.SecureCode.ProductType)
                .ThenInclude(x => x.ProductType)
                .Where(x => x.PlansCode == code).FirstOrDefault();
        }

        public void Create(SecurePlansEntitie entity)
        {
            Insert(entity);
        }
    }
}