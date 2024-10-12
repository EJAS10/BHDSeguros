using BHDSeguros.Domain.Entities.Client;

namespace BHDSeguros.Domain.Interfaces.Repository.Client
{
    public interface IClientRepository
    {
        void Create(ClientEntitie entity);

        ClientEntitie? GetClientByIdentification(string identification, bool LoadInclude = true);
    }
}
