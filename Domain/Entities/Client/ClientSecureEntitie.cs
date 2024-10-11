using BHDSeguros.Domain.Entities.Commun;
using BHDSeguros.Domain.Entities.SecureApplications;

namespace BHDSeguros.Domain.Entities.Client
{
    public class ClientSecureEntitie : Communs
    {
        public int ClientId { get; set; }
        public ClientEntitie Client { get; set; }

        public int SecurePlansId { get; set; }
        public SecurePlansEntitie SecurePlans { get; set; }

        public string Policy { get; set; }
    }
}
