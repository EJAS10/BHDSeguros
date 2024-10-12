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

        public int ProductTypeId { get; set; }

        public ProductTypeEntitie ProductType { get; set; }

        public string ProductNumber { get; set; }

        public string Policy { get; set; }
    }
}
