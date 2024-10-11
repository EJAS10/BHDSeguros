using System.ComponentModel.DataAnnotations;

namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class AllowedProductTypeDto
    {
        [Required]
        public string ProductTypeName { get; set; }

        public List<SecureCodeDto> SeguroEntitieList { get; set; }

        public List<SecureApplicationsDto> SecureApplications { get; set; }
    }
}
