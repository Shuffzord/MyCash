using System;
using System.Collections.Generic;
using System.Linq;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity

    {
        private readonly Ctx _ctx;
        public Repository(Ctx ctx)
        {
            _ctx = ctx;
        }

        public void Save(){
            _ctx.SaveChanges();
        }

        void IRepository<T>.Add(T item)
        {
            _ctx.Add<T>(item);
            Save();
        }

        T IRepository<T>.Find(long key)
        {
            return _ctx.Set<T>().Single(x => x.Id == key);
        }

        public IEnumerable<T> GetAll()
        {
           return _ctx.Set<T>();
        }

        void Remove(T entity)
        {
           _ctx.Set<T>().Remove(entity);
        }

        void IRepository<T>.Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}