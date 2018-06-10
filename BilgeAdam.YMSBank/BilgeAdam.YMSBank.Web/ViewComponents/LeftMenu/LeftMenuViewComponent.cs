using BilgeAdam.YMSBank.DataTransferObjects;
using BilgeAdam.YMSBank.Web.Models.Enterprise;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.ViewComponents.LeftMenu
{
    [ViewComponent(Name = "LeftMenu")]
    public class LeftMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //TODO : Use Generic Proxy Handler
            var client = new HttpClient
            {
                BaseAddress = new System.Uri("http://localhost:60755")//TODO Use config
            };

            var response = await client.GetAsync("api/Menu/GetAllActiveMenus");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<IEnumerable<MenuDto>>(result);
                var vm = new MenuViewModel();

                var modules = data.ToList().Select(i => new
                {
                    Text = i.ModuleText,
                    Id = i.ModuleId
                }).Distinct();
                foreach (var m in modules)
                {
                    var newModule = vm.AddModule(m.Text);
                    var moduleViews = data.Where(i => i.ModuleId == m.Id && !i.ParentId.HasValue).ToList();
                    foreach (var v in moduleViews)
                    {
                        newModule.Views.Add(new MenuViewModel.View
                        {
                            Action = v.Action,
                            Controller = v.Controller,
                            Area = v.Area,
                            Text = v.Text
                        });
                    }
                    //TODO : alt menüler eklenecek
                }
                return View(vm);
            }
            await Task.CompletedTask;
            return View();
        }
    }
}
