using BilgeAdam.YMSBank.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using BilgeAdam.YMSBank.Common;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.YMSBank.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;
        private readonly IServiceProvider provider;

        public UnitOfWork(IServiceProvider provider)
        {
            context = provider.GetService(typeof(DbContext)) as DbContext;
            this.provider = provider;
        }
        public IRepository<T> Repository<T>() where T : EntityBase
        {
            return provider.GetService(typeof(IRepository<T>)) as IRepository<T>;
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
