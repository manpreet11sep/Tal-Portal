using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public double Get()
        {
            return 44.33;
        }
    }
}