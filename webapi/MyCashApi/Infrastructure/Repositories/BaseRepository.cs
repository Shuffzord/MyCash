using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure.Repositories
{
  public class BaseRepository<T> : IRepository<T> where T : BaseEntity

  {
    protected readonly Ctx _ctx;
    private DbSet<T> entities;
    public BaseRepository(Ctx ctx)
    {
      _ctx = ctx;
      entities = _ctx.Set<T>();
    }

    public void Save()
    {
      _ctx.SaveChanges();
    }

    void IRepository<T>.Add(T item)
    {
      entities.Add(item);
      Save();
    }

    T IRepository<T>.Find(long key)
    {
      return entities.Single(x => x.Id == key);
    }

    public virtual IQueryable<T> GetAll()
    {
      return entities;
    }
    public void Remove(T entity)
    {
      entities.Remove(entity);
    }
  }
}