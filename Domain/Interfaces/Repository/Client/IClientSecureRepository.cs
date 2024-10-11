using BHDSeguros.Domain.Entities.Client;

namespace BHDSeguros.Domain.Interfaces.Repository.Client
{
    public interface IClientSecureRepository
    {
        void Create(ClientSecureEntitie entity);
    }
}
