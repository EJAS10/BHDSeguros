using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Interfaces.Repository.Client;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BHDSeguros.Infrastructure.Repository.Client
{
    public class ClientSecureRepository : RepositoryBase<ClientSecureEntitie, DataBaseContext>, IClientSecureRepository
    {

        private readonly DataBaseContext _context;
        public ClientSecureRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }

        public List<ClientSecureEntitie> GetClientSecuresById(int id)
        {
            return _context.Set<ClientSecureEntitie>()               
                .Include(x => x.ProductType)
                .Include(x => x.SecurePlans)
                    .ThenInclude(x => x.SecureCode)
                .Where(x => x.ClientId.Equals(id)).ToList();
        }

        public void Create(ClientSecureEntitie entity)
        {
            Insert(entity);
        }
    }
}
