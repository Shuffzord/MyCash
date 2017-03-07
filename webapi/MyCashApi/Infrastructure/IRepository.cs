using System.Collections.Generic;

namespace MyCashApi.Infrastructure
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T Find(long key);
        void Remove(T entity);
        void Save();
    }
}