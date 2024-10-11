using BHDSeguros.Domain.Entities.Commun;
using BHDSeguros.Domain.Entities.SecureApplications;
using System.ComponentModel.DataAnnotations;

namespace BHDSeguros.Domain.Entities.Client
{
    public class ClientEntitie : Communs
    {
        [Required]
        public string ClientName { get; set; }

        [Required]
        public string ClientLastName { get; set; }

        [Required]
        public string ClientIdentification { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public List<ClientSecureEntitie> ClientSecure { get; set; }

        public List<SecureApplicationsEntitie> ClientApplications { get; set; }
    }
}
