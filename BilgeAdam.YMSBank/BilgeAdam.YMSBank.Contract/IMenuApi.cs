using BilgeAdam.YMSBank.Common;
using BilgeAdam.YMSBank.DataTransferObjects;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Contract
{
    public interface IMenuApi : IApiBase
    {
        IEnumerable<MenuDto> GetAllActiveMenus();
    }
}
