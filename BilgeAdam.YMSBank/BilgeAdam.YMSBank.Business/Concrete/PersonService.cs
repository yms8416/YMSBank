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
    public class PersonService : IPersonApi
    {
        IUnitOfWork UnitOfWork { get; set; }

        public PersonService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public IEnumerable<PersonDto> GetPeople()
        {
            return UnitOfWork.Repository<Person>().Select(i => new PersonDto
            {
                Id = i.Id,
                FullName = $"{i.FirstName} {i.LastName}",
                EMail = i.EMail
            }).ToList();
        }
    }
}
