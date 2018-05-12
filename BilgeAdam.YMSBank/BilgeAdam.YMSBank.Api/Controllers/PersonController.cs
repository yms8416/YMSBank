using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.YMSBank.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        public IEnumerable<string> GetText()
        {
            return new List<string> { "Can", "Perk" };
        }
    }
}