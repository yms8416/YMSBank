using BilgeAdam.YMSBank.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.YMSBank.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : EntityBase;
        int Save();
    }
}