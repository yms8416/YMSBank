using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.UserMenu
{
    [ViewComponent(Name = "UserMenu")]
    public class UserMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
