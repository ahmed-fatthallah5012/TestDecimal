using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestDecimal.GenericTools;

namespace TestDecimal.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(DecimalsTool.GetNewId());
        }
    }
}
