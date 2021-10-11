using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace redis_test.api.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult ServiceResponse(object data)
        {
            return StatusCode(200, new { data });
        }
    }
}
