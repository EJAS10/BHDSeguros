namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class ClientSecurePlansDto
    {
        public string SecureType { get; set; }

        public string SecureNumber { get; set; }

        public string SecurePlan { get; set; }

        public string TypeProduct { get; set; }

        public string ProductNumber { get; set; }

        public DateTime DateSell { get; set; }

        public decimal PlanFee { get; set; }
    }
}
