using System.ComponentModel.DataAnnotations;

namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class AllowedAgeDto
    {
        [Required]
        public int Age { get; set; }

        public List<SecureCodeDto>  SecureCodes { get; set; }
    }
}
