using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilgeAdam.YMSBank.Contract;
using BilgeAdam.YMSBank.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.YMSBank.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Menu")]
    public class MenuController : Controller, IMenuApi
    {
        private readonly IMenuApi api;

        public MenuController(IMenuApi api)
        {
            this.api = api;
        }
        [HttpGet(nameof(GetAllActiveMenus))]
        public IEnumerable<MenuDto> GetAllActiveMenus()
        {
            return api.GetAllActiveMenus();
        }
    }
}