using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Tal.Insurance.Portal.Interface.PremiumService;
using Tal.Insurance.Portal.Modal.Modal;
using Tal.Insurance.Portal.Web.Model;

namespace Tal.Insurance.Portal.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsurancePremiumController : ControllerBase
    {
        IPremiumService _premiumService;    

        private readonly ILogger<InsurancePremiumController> _logger;

        public InsurancePremiumController(ILogger<InsurancePremiumController> logger, IPremiumService premiumService)
        {
            _logger = logger;
            _premiumService = premiumService;
        }

        [HttpGet]

        public CalculateResponse Get(string age, string occupation, string suminsured)
        {
            var usr = new UserDetails() {
                Age = Convert.ToInt32(age),
                Occupation = occupation,
                SumInsured = Convert.ToInt32(suminsured)
            };
            return new CalculateResponse
            {
                calculatedPremium = _premiumService.CalculatePremium(usr)
            };
        }


    }
}