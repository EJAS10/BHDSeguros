using BHDSeguros.Domain.DTOs.Client;
using System.ComponentModel.DataAnnotations;

namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class SecureApplicationsDto
    {
        [Required]
        public required string ClientName { get; set; }

        [Required]
        public required string ClientLastName { get; set; }

        [Required]
        public required string ClientIdentification { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public required string TypeSecure { get; set; }

        [Required]
        public required string SecurePlan { get; set; }

        [Required]
        public required string ProductTpe { get; set; }

        [Required]
        public required string ProductNumber { get; set; }
    }
}
