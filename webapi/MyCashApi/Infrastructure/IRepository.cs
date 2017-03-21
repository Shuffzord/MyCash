using System.Collections.Generic;
using System.Linq;

namespace MyCashApi.Infrastructure
{
  public interface IRepository<T>
  {
    void Add(T item);
    IQueryable<T> GetAll();
    T Find(long key);
    void Remove(T entity);
    void Save();
    void Update(T entity);
  }

}