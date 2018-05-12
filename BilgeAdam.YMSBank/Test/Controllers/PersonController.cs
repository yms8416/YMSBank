using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet("GetText")]
        public IEnumerable<string> GetText()
        {
            return new List<string> { "Can", "Perk" };
        }
    }
}