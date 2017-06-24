﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fibon.Service.Controllers
{
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("Helo world from FibonApi");
        }
    }
}
