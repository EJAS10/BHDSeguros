using System.ComponentModel.DataAnnotations;
using BHDSeguros.Domain.Entities.Commun;

namespace BHDSeguros.Domain.Entities.SecureApplications
{
    public class ProductTypeEntitie : Communs
    {

        [Required]
        public string ProductTypeName { get; set; }

        public List<SecureCodeProductTypeEntitie> SeguroEntitieList { get; set; }

    }
}
