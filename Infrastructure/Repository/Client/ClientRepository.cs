using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Interfaces.Repository.Client;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace BHDSeguros.Infrastructure.Repository.Client
{
    public class ClientRepository : RepositoryBase<ClientEntitie, DataBaseContext>, IClientRepository
    {

        private readonly DataBaseContext _context;
        public ClientRepository(DataBaseContext dbcontext)
            : base(dbcontext)
        {
            _context = dbcontext;
        }

        public void Create(ClientEntitie entity)
        {
            Insert(entity);
        }

        public ClientEntitie? GetClientByIdentification(string identification, bool LoadInclude = true)
        {
            var query = _context.Set<ClientEntitie>().AsQueryable();
            if (LoadInclude)
                query.Include(x => x.ClientSecure);

            return query.Where(x => x.ClientIdentification.Equals(identification)).FirstOrDefault();
        }
    }
}
