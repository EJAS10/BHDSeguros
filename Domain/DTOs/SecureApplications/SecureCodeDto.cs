namespace BHDSeguros.Domain.DTOs.SecureApplications
{
    public class SecureCodeDto
    {
        public string SecureCode { get; set; }
        public string CodeName { get; set; }

        public int AllowedProductTypeId { get; set; }
        public AllowedProductTypeDto AllowedProductType { get; set; }

        public List<SecureApplicationsDto> SecureApplications { get; set; }
    }
}