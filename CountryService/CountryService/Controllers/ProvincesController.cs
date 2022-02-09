using CountryService.Business;
using CountryService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvincesController : ControllerBase
    {
        private readonly ILogger<ProvincesController> _logger;
        private readonly IProvinceBusiness _province;

        public ProvincesController(ILogger<ProvincesController> logger, IProvinceBusiness provinceBusiness)
        {
            _logger = logger;
            _province = provinceBusiness;
        }

        [HttpGet]
        public async Task<IEnumerable<Province>> Get()
        {
           return await _province.GetAll();
        }
    }
}
