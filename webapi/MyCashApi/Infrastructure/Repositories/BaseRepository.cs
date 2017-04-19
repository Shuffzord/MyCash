using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure.Repositories
{
  public class BaseRepository<T> : IRepository<T> where T : BaseEntity

  {
    protected readonly Ctx _ctx;
    private readonly DbSet<T> entities;
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
      if (entities is IQueryable<SoftDeleteEntity>)
      {
        return entities.Where((x => !(x as SoftDeleteEntity).IsDeleted));
      }
      return entities;
    }
    public void Remove(T entity)
    {
      entities.Remove(entity);
    }

    public void Update(T entity)
    {
      entities.Update(entity);
    }

    public T Find(Expression<Func<T, bool>> expression)
    {
      return entities.SingleOrDefault(expression);
    }

  }
}