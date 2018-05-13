using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BilgeAdam.YMSBank.Contract;
using BilgeAdam.YMSBank.DataTransferObjects;

namespace BilgeAdam.YMSBank.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Lookup")]
    public class LookupController : Controller, ILookupApi
    {
        private readonly ILookupApi api;

        public LookupController(ILookupApi api)
        {
            this.api = api;
        }
        [HttpGet(nameof(GetLookups))]
        public IEnumerable<LookupDto> GetLookups()
        {
            return api.GetLookups();
        }
        [HttpGet("GetByTypeId/{typeId}")]
        public IEnumerable<LookupDto> GetLookupsByLookupTypeId(long typeId)
        {
            return api.GetLookupsByLookupTypeId(typeId);
        }
        [HttpGet(nameof(GetLookupTypes))]
        public IEnumerable<LookupTypeDto> GetLookupTypes()
        {
            return api.GetLookupTypes();
        }
    }
}