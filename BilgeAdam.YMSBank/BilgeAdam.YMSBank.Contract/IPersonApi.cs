using BilgeAdam.YMSBank.Common;
using BilgeAdam.YMSBank.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.YMSBank.Contract
{
    public interface IPersonApi : IApiBase
    {
        IEnumerable<PersonDto> GetPeople();
    }
}
