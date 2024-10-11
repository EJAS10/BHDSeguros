using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Entities.Commun;

namespace BHDSeguros.Domain.Entities.SecureApplications
{
    public class SecurePlansEntitie : Communs
    {
        public string PlansCode { get; set; }
        public string PlansName { get; set; }
        public decimal PlanFee { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int SecureCodeId { get; set; }
        public SecureCodeEntitie SecureCode { get; set; }

        public List<SecureApplicationsEntitie> SecureApplications { get; set; }

        public List<ClientSecureEntitie> ClientSecure { get; set; }
    }
}
