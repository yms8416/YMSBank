using BilgeAdam.YMSBank.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using BilgeAdam.YMSBank.DataTransferObjects;
using BilgeAdam.YMSBank.Data.Context;
using System.Linq;

namespace BilgeAdam.YMSBank.Business.Concrete
{
    public class LookupService : ILookupApi
    {
        private readonly YMSContext context;

        public LookupService(YMSContext context)
        {
            this.context = context;
        }
        public IEnumerable<LookupDto> GetLookups()
        {
            return context.GenericLookups.Select(i => new LookupDto
            {
                Id = i.Id,
                Name = i.Name,
                Type = new LookupTypeDto
                {
                    Id = i.GenericLookupType.Id,
                    Name = i.GenericLookupType.Name
                }
            }).ToList();
        }

        public IEnumerable<LookupDto> GetLookupsByLookupTypeId(long typeId)
        {
            return context.GenericLookups.Where(i => i.GenericLookupTypeId == typeId).Select(i => new LookupDto
            {
                Id = i.Id,
                Name = i.Name,
                Type = new LookupTypeDto
                {
                    Id = i.GenericLookupType.Id,
                    Name = i.GenericLookupType.Name
                }
            }).ToList();
        }

        public IEnumerable<LookupTypeDto> GetLookupTypes()
        {
            return context.GenericLookupTypes.Select(i => new LookupTypeDto
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
        }
    }
}
