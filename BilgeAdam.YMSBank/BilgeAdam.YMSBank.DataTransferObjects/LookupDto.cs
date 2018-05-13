using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.YMSBank.DataTransferObjects
{
    public class LookupDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public LookupTypeDto Type { get; set; }
    }
}
