using BHDSeguros.Domain.Entities.Commun;

namespace BHDSeguros.Domain.Entities.SecureApplications
{
    public class SecureCodeEntitie : Communs
    {
        public string SecureCode { get; set; }
        public string CodeName { get; set; }
        public List<SecureCodeProductTypeEntitie> ProductType { get; set; }
    }
}