using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.Infrastructure.Repository.SecureApplication
{
    public class SecureCodeRepository : RepositoryBase<SecureCodeEntitie, DataBaseContext>, ISecureCodeRepository
    {

        private readonly DataBaseContext _context;
        public SecureCodeRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }
      

        public void Create(SecureCodeEntitie entity)
        {
            Insert(entity);
        }
    }
}