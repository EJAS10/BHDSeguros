using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Entities.Commun;
using BHDSeguros.Domain.Enums;

namespace BHDSeguros.Domain.Entities.SecureApplications
{
    public class SecureApplicationsEntitie : Communs
    {

        public int ClientId { get; set; }
        public ClientEntitie Client { get; set; }
      
        public int SecurePlansId { get; set; }
        public SecurePlansEntitie SecurePlans { get; set; }

        public int ProductTypeId { get; set; }
        public ProductTypeEntitie ProductType { get; set; }

        public string ProductNumber { get; set; }

        public SolicitudStatusEnum SolicitudStatus { get; set; }
        public string? Message { get; set; }
    }
}
