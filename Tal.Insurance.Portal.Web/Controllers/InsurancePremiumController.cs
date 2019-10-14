using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

using Tal.Insurance.Portal.Web.Model;

namespace Tal.Insurance.Portal.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsurancePremiumController : ControllerBase
    {       

        private readonly ILogger<InsurancePremiumController> _logger;

        public InsurancePremiumController(ILogger<InsurancePremiumController> logger)
        {
            _logger = logger;
        }

        [HttpGet]   

        public CalculateResponse Get()
        {
            var rng = new Random();
            return new CalculateResponse
            {
                calculatedPremium = 44.33
            };
        }
    }
}