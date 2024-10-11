using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;

namespace Facturacion.Infrastructure.Repository.SecureApplication
{
    public class SecureApplicationRepository : RepositoryBase<SecureApplicationsEntitie, DataBaseContext>, ISecureApplicationRepository
    {
      
        private readonly DataBaseContext _context;
        public SecureApplicationRepository(DataBaseContext dbcontext) 
            : base(dbcontext)
        {
            _context = dbcontext;
        }

        public void Create(SecureApplicationsEntitie secure)
        {
            Insert(secure);
        }
    }
}
