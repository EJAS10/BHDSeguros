using BHDSeguros.Domain.DTOs.Client;

namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class SecurePlansDto
    {
        public string PlansCode { get; set; }
        public string PlansName { get; set; }
        public string Suscription { get; set; }

        public int AllowedMinAgeId { get; set; }
        public AllowedAgeDto AllowedMinAge { get; set; }

        //public int AllowedMaxAgeId { get; set; }
        //public AllowedAgeDto AllowedMaxAge { get; set; }

        public List<SecureApplicationsDto> SecureApplications { get; set; }

        public List<ClientSecureDto> ClientSecure { get; set; }
    }
}
