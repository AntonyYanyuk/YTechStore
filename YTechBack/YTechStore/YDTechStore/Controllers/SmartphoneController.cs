using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTechStore.Models;
using System.Data.SqlClient;
using System.Data;
using YTechStore.IServices;

namespace YTechStore.Controllers
{
    [ApiController]
    [Route("api")]
    public class SmartphoneController : ControllerBase
    {
        private ISmartphoneService _smartphoneService;

        public SmartphoneController(ISmartphoneService smartphoneService)
        {
            _smartphoneService = smartphoneService;
        }

        // POST: api/Smartphone
        [HttpPost, Route("addSmartphone")]
        public Smartphone AddSmartphone([FromBody] Smartphone smartphone)
        {
            if (ModelState.IsValid) return _smartphoneService.Save(smartphone);
            return null;
        }
    }
}
