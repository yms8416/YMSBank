using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.YMSBank.DataTransferObjects
{
    public class MenuDto
    {
        public long Id { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Text { get; set; }
        public long? ParentId { get; set; }
        public long? ModuleId { get; set; }
        public string ModuleText { get; set; }
    }
}
