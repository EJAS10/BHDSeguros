using AutoMapper;
using BHDSeguros.Domain.DTOs.SecureApplications;
using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Entities.SecureApplications;
using BHDSeguros.Domain.Enums;
using BHDSeguros.Domain.Helpers.Date;
using BHDSeguros.Domain.Interfaces.Repository.Client;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Domain.Interfaces.Services.SecureApplication;
using BHDSeguros.Domain.Structs;

namespace BHDSeguros.Application.Servicios.SecureApplications
{
    public class SecureApplicationService : ISecureApplicationService
    {
        private readonly ISecureApplicationRepository _secureApplicationRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ISecurePlansRepository _securePlansRepository;
        private readonly IClientSecureRepository _clientSecureRepository;
        private readonly IProductTypeRepository _allowedProductTypeRepository;
        private readonly IMapper _mapper;

        public SecureApplicationService(IMapper mapper, ISecureApplicationRepository secureApplicationRepository, IClientRepository clientRepository,
            ISecurePlansRepository securePlansRepository, IClientSecureRepository clientSecureRepository, IProductTypeRepository allowedProductTypeRepository)
        {
            _mapper = mapper;
            _secureApplicationRepository = secureApplicationRepository;
            _clientRepository = clientRepository;
            _securePlansRepository = securePlansRepository;
            _clientSecureRepository = clientSecureRepository;
            _allowedProductTypeRepository = allowedProductTypeRepository;
        }

        public List<ClientSecurePlansDto> GetClientSecurePlans(string Identification)
        {
            List<ClientSecurePlansDto> Response = new List<ClientSecurePlansDto>();
            var Client = _clientRepository.GetClientByIdentification(Identification, false);
            if (Client != null) 
            {
                var ClientSecures = _clientSecureRepository.GetClientSecuresById(Client.Id);
                Response = _mapper.Map<List<ClientSecurePlansDto>>(ClientSecures);
            }
            return Response;   
        }

        public string Create(SecureApplicationsDto secure)
        {
            var Application = SetApplicationData(secure);
            _secureApplicationRepository.Create(Application);

            if (Application.SolicitudStatus.Equals(SolicitudStatusEnum.Rechazado))
                throw new Exception(Application.Message);
            else
                return CreateClientSecure(Application);
        }

        private SecureApplicationsEntitie SetApplicationData(SecureApplicationsDto secureApplicationDto)
        {
            var client = _clientRepository.GetClientByIdentification(secureApplicationDto.ClientIdentification) ?? CreateClient(secureApplicationDto);
            var SecurePlan = GetSecurePlan(secureApplicationDto);
            bool IsValidApplication = true;
            var Application = new SecureApplicationsEntitie();
            Application.SolicitudStatus = SolicitudStatusEnum.Aprobado;
            Application.ClientId = client.Id;
            Application.SecurePlansId = SecurePlan.Id;
            Application.ProductNumber = secureApplicationDto.ProductNumber;

            IsValidApplication = SetProductType(secureApplicationDto, Application, SecurePlan);
            IsValidApplication = CheckUserPlans(client, Application, SecurePlan);
            IsValidApplication = CheckClientAge(client, Application, SecurePlan);

            return Application;
        }

        private bool CheckClientAge(ClientEntitie client, SecureApplicationsEntitie Application, SecurePlansEntitie SecurePlan)
        {
            bool IsValidApplication = false;
            int Age = DateHelper.CalcularEdad(client.DateOfBirth);
            if (Age < SecurePlan.MinAge || Age > SecurePlan.MaxAge)
            {
                Application.Message += ErrorMessagesStruct.INVALIDAGE;
                Application.SolicitudStatus = SolicitudStatusEnum.Rechazado;
                IsValidApplication = false;
            }

            return IsValidApplication;
        }

        private bool CheckUserPlans(ClientEntitie client, SecureApplicationsEntitie Application, SecurePlansEntitie SecurePlan)
        {
            bool IsValidApplication = false;
            if (client.ClientSecure != null && client.ClientSecure.Count > 0)
            {
                if (client.ClientSecure.Any(x => x.SecurePlansId.Equals(SecurePlan.Id)))
                {
                    Application.Message += ErrorMessagesStruct.CLIENTALREADYGOTTHISPLAN;
                    Application.SolicitudStatus = SolicitudStatusEnum.Rechazado;
                    IsValidApplication = false;
                }
            }

            return IsValidApplication;
        }

        private bool SetProductType(SecureApplicationsDto secureApplicationDto, SecureApplicationsEntitie Application, SecurePlansEntitie SecurePlan)
        {
            bool IsValidApplication = false;
            var SecureCodeProductType = SecurePlan.SecureCode.ProductType.FirstOrDefault(x => x.ProductType.ProductTypeName.Equals(secureApplicationDto.ProductTpe));
            if (SecureCodeProductType != null)
            {
                Application.ProductTypeId = SecureCodeProductType.Id;
            }
            else
            {
                var ProductType = _allowedProductTypeRepository.GetByName(secureApplicationDto.ProductTpe);
                if (ProductType != null)
                    Application.ProductTypeId = ProductType.Id;
                else
                    throw new Exception(ErrorMessagesStruct.INVALIDPRODUCTTYPE);

                Application.Message += ErrorMessagesStruct.INVALIDPRODUCTTYPEFORPLAN;
                Application.SolicitudStatus = SolicitudStatusEnum.Rechazado;
                IsValidApplication = false;
            }

            return IsValidApplication;
        }

        private SecurePlansEntitie GetSecurePlan(SecureApplicationsDto secureApplicationDto)
        {
            var SecurePlan = _securePlansRepository.GetByCode(secureApplicationDto.SecurePlan);
            if (SecurePlan == null)
                throw new Exception(ErrorMessagesStruct.INVALIDSECURETYPE);
            return SecurePlan;
        }

        private ClientEntitie CreateClient(SecureApplicationsDto secureApplicationDto)
        {
            var clientEntitie = _mapper.Map<ClientEntitie>(secureApplicationDto);
            _clientRepository.Create(clientEntitie);
            return clientEntitie;
        }

        private string CreateClientSecure(SecureApplicationsEntitie secureApplication)
        {
            var clientSecureEntitie = new ClientSecureEntitie();
            clientSecureEntitie.ClientId = secureApplication.ClientId;
            clientSecureEntitie.SecurePlansId = secureApplication.SecurePlans.Id;
            clientSecureEntitie.ProductNumber = secureApplication.ProductNumber;
            clientSecureEntitie.ProductTypeId = secureApplication.ProductTypeId;
            clientSecureEntitie.Policy = GeneratePolicy(secureApplication);
            _clientSecureRepository.Create(clientSecureEntitie);

            return clientSecureEntitie.Policy;
        }

        private string GeneratePolicy(SecureApplicationsEntitie secure)
        {
            return $"{secure.SecurePlans.SecureCode.SecureCode}-{secure.SecurePlans.PlansCode}-{secure.Id.ToString().PadLeft(5, '0')}";
        }      
    }
}
