using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MyCashApi.Extensions
{
  public static class QueryExtensions
  {
    public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) where T : class
    {
      if (includes != null)
      {
        query = includes.Aggregate(query,
                  (current, include) => current.Include(include));
      }

      return query;
    }
  }
}