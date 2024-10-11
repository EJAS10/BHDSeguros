using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Interfaces.Repository.Client;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;

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

        public void Create(ClientSecureEntitie entity)
        {
            Insert(entity);
        }
    }
}
