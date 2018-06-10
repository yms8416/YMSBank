using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam.YMSBank.Web.Models.Enterprise
{
    public class MenuViewModel
    {
        public MenuViewModel()
        {
            Modules = new List<Module>();
        }
        public List<Module> Modules { get; set; }
        public Module AddModule(string Text)
        {
            var module = new Module { Name = Text };
            Modules.Add(module);
            return module;
        }
        public class Module
        {
            public Module()
            {
                Views = new List<View>();
            }
            public string Name { get; set; }
            public List<View> Views { get; set; }
        }
        public class View
        {
            public string Text { get; set; }
            public string Action { get; set; }
            public string Controller { get; set; }
            public string Area { get; set; }
        }
    }
}
