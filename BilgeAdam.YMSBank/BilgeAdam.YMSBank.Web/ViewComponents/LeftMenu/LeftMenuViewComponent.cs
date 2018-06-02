using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.LeftMenu
{
    [ViewComponent(Name = "LeftMenu")]
    public class LeftMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
