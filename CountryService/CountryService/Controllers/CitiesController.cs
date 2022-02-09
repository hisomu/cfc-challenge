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
    public class CitiesController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly ICityBusiness _city;

        public CitiesController(ILogger<CitiesController> logger, ICityBusiness cityBusiness)
        {
            _logger = logger;
            _city = cityBusiness;
        }

        [HttpGet]
        public async Task<IEnumerable<City>> Get()
        {
            return await _city.GetAll();
        }

        [HttpGet]
        [Route("{province}")]
        public async Task<IEnumerable<City>> GetByProvince(string province)
        {
            return await _city.GetAllByProvince(province);
        }
    }
}
