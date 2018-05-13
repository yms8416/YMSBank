using BilgeAdam.YMSBank.Common;
using BilgeAdam.YMSBank.DataTransferObjects;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Contract
{
    public interface ILookupApi : IApiBase
    {
        IEnumerable<LookupDto> GetLookups();
        IEnumerable<LookupTypeDto> GetLookupTypes();
        IEnumerable<LookupDto> GetLookupsByLookupTypeId(long typeId);
    }
}
