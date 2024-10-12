using BHDSeguros.Domain.Entities.Client;

namespace BHDSeguros.Domain.Interfaces.Repository.Client
{
    public interface IClientSecureRepository
    {
        List<ClientSecureEntitie> GetClientSecuresById(int id);
        void Create(ClientSecureEntitie entity);
    }
}
