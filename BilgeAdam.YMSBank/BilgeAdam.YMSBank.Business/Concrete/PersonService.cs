using BilgeAdam.YMSBank.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using BilgeAdam.YMSBank.DataTransferObjects;
using BilgeAdam.YMSBank.Data.Context;
using System.Linq;

namespace BilgeAdam.YMSBank.Business.Concrete
{
    public class PersonService : IPersonApi
    {
        private readonly YMSContext context;

        public PersonService(YMSContext context)
        {
            this.context = context;
        }
        public IEnumerable<PersonDto> GetPeople()
        {
            return context.People.Select(i => new PersonDto
            {
                Id = i.Id,
                FullName = $"{i.FirstName} {i.LastName}",
                EMail = i.EMail
            }).ToList();
        }
    }
}
