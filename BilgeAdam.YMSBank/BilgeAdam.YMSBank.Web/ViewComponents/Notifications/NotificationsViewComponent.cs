using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.Notifications
{
    [ViewComponent(Name = "notifications")]
    public class NotificationsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
