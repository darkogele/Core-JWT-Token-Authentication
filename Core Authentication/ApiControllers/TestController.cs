using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Authentication.ApiControllers
{
    [Route("api/[controller]/[action]")]
    //[Route("Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
      
        public IActionResult Daro()
        {
            return Content("Test rabote");
        }
    
        public IActionResult Daro1()
        {
            return Content("Test rabote Pak");
        }
    }
}