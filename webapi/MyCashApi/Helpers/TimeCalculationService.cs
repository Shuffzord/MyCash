using System;
using MyCashApi.Entities;
using MyCashApi.Enums;

namespace MyCashApi.Helpers
{
  public static class TimeCalculationService
  {
    public static int DateDifferenceFrom(DateTime initialDate, Interval granulation, DateTime? todayDate = null)
    {
      var now = todayDate ?? DateTime.UtcNow;
      if (now < initialDate) return 0;

      switch (granulation)
      {
        case Interval.Monthly:
          return (now.Month - initialDate.Month) + 12 * (now.Year - initialDate.Year);
        case Interval.Daily:
          return (now - initialDate).Days;
        case Interval.Yearly:
          return now.Year - initialDate.Year;
        default:
          throw new ArgumentOutOfRangeException(nameof(granulation), granulation, null);
      }
    }
  }
}