using BHDSeguros.Domain.DTOs.SecureApplications;
using BHDSeguros.Domain.Interfaces.Services.SecureApplication;
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
        public IActionResult Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return Ok("Ready");
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
