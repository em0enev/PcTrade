using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcTrade.Controllers
{
    public class TestController : BaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { name = "ivan" });
        }
    }
}
