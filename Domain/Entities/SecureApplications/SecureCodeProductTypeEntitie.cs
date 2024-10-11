using BHDSeguros.Domain.Entities.Commun;

namespace BHDSeguros.Domain.Entities.SecureApplications
{
    public class SecureCodeProductTypeEntitie : Communs
    {
        public int SecureCodeId { get; set; }

        public SecureCodeEntitie SecureCode { get; set; }

        public int ProductTypeId { get; set; }

        public ProductTypeEntitie ProductType { get; set; }
    }
}
