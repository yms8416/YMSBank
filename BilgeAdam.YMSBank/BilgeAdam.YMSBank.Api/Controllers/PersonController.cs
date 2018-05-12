using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BilgeAdam.YMSBank.Data.Context;
using System.Linq;
using BilgeAdam.YMSBank.DataTransferObjects;
using BilgeAdam.YMSBank.Contract;

namespace BilgeAdam.YMSBank.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller, IPersonApi
    {
        private readonly IPersonApi api;

        public PersonController(IPersonApi api)
        {
            this.api = api;
        }

        [HttpGet(nameof(GetPeople))]
        public IEnumerable<PersonDto> GetPeople()
        {
            return api.GetPeople();
        }
    }
}

//YAGNI -> You Aren't Gonna Need It
//SOLID -> Ana yasa gibi (KHK)


    //martin fowler takip edin