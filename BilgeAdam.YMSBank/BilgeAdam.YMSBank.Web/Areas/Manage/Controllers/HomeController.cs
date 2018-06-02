using BilgeAdam.YMSBank.Web.Utilities.Constants;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.YMSBank.Web.Areas.Manage.Controllers
{
    [Area(RouteNames.AreaNames.Manage)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}