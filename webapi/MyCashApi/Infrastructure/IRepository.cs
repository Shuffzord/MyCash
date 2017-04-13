using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure
{
  public interface IRepository<T>
  {
    void Add(T item);
    IQueryable<T> GetAll();
    T Find(long key);
    T Find(Expression<Func<T,bool>> expression);
    void Remove(T entity);
    void Save();
    void Update(T entity);
  }

}