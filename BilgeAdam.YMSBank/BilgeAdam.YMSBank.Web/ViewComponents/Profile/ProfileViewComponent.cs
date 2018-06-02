using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.Profile
{
    [ViewComponent(Name = "Profile")]
    public class ProfileViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
