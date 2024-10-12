using BHDSeguros.Domain.DTOs.SecureApplications;
using BHDSeguros.Domain.Interfaces.Services.SecureApplication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace BHDSeguros.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SecureApplicationsController : ControllerBase
    {


        private readonly ILogger<SecureApplicationsController> _logger;
        private readonly ISecureApplicationService _secureApplicationService;

        public SecureApplicationsController(ILogger<SecureApplicationsController> logger, ISecureApplicationService secureApplicationService)
        {
            _logger = logger;
            _secureApplicationService = secureApplicationService;
        }

        [HttpGet]
        public IActionResult CheckStatus()
        {
            return Ok("Ready");
        }

        [HttpGet]
        public IActionResult Get(string Identification)
        {
            try
            {
                return Ok(_secureApplicationService.GetClientSecurePlans(Identification));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Create(SecureApplicationsDto secure)
        {
            try
            {
                string Policy = _secureApplicationService.Create(secure);
                return Ok($"Solicitude de seguro aprobada, Poliza {Policy}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
