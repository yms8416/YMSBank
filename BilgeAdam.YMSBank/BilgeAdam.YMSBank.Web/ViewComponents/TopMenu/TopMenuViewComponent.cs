using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.TopMenu
{
    [ViewComponent(Name = "TopMenu")]
    public class TopMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
