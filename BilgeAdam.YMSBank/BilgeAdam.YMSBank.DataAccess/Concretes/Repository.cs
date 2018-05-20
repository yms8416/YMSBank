using BilgeAdam.YMSBank.Common;
using BilgeAdam.YMSBank.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.YMSBank.DataAccess.Concretes
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext context;
        private readonly DbSet<T> set;

        public Repository(DbContext context)
        {
            this.context = context;
            set = context.Set<T>();
        }
        public Type ElementType => set.AsNoTracking().ElementType;

        public Expression Expression => set.AsNoTracking().Expression;

        public IQueryProvider Provider => set.AsNoTracking().Provider;

        public void Add(T entity)
        {
            entity.Created = DateTime.Now;
            entity.Updated = DateTime.Now;
            context.Entry(entity).State = EntityState.Added;
            set.Attach(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.Updated = DateTime.Now;
            context.Entry(entity).State = EntityState.Modified;
            set.Attach(entity);
        }

        public void Delete(long id)
        {
            var entity = set.FirstOrDefault(i => i.Id == id);
            if (entity != null)
            {
                Delete(entity);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return set.AsNoTracking().GetEnumerator();
        }

        public void Update(T entity)
        {
            entity.Updated = DateTime.Now;
            context.Entry(entity).State = EntityState.Modified;
            set.Attach(entity);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return set.AsNoTracking().GetEnumerator();
        }
    }
}
