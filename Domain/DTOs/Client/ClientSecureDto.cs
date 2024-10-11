using BHDSeguros.Domain.DTOs.SecureApplications;

namespace BHDSeguros.Domain.DTOs.Client
{
    public class ClientSecureDto
    {
        public int ClientId { get; set; }
        public ClientDto Client { get; set; }

        public int SecurePlansId { get; set; }
        public SecurePlansDto SecurePlans { get; set; }
    }
}
