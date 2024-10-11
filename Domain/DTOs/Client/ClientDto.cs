using BHDSeguros.Domain.DTOs.SecureApplications;
using System.ComponentModel.DataAnnotations;

namespace BHDSeguros.Domain.DTOs.Client
{
    public class ClientDto
    {
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string ClientLastName { get; set; }

        [Required]
        public string ClientIdentification { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public List<ClientSecureDto> ClientSecure { get; set; }

        public List<SecureApplicationsDto> ClientApplications { get; set; }



    }
}
