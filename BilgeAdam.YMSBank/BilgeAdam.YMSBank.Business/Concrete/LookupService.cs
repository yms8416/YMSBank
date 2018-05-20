using BilgeAdam.YMSBank.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using BilgeAdam.YMSBank.DataTransferObjects;
using BilgeAdam.YMSBank.Data.Context;
using System.Linq;
using BilgeAdam.YMSBank.DataAccess.Contracts;
using BilgeAdam.YMSBank.Data.Entities;

namespace BilgeAdam.YMSBank.Business.Concrete
{
    public class LookupService : ILookupApi
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public LookupService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public IEnumerable<LookupDto> GetLookups()
        {
            return UnitOfWork.Repository<GenericLookup>().Select(i => new LookupDto
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
            return UnitOfWork.Repository<GenericLookup>().Where(i => i.GenericLookupTypeId == typeId).Select(i => new LookupDto
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
            return UnitOfWork.Repository<GenericLookupType>().Select(i => new LookupTypeDto
            {
                Id = i.Id,
                Name = i.Name
            }).ToList();
        }
    }
}
