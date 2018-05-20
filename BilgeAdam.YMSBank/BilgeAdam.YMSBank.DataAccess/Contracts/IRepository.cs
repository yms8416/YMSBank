using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilgeAdam.YMSBank.DataAccess.Contracts
{
    public interface IRepository<T> : IQueryable<T> where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(long id);
    }
}
