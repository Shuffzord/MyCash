using System;
using System.Collections.Generic;
using System.Linq;
using MyCashApi.Enums;

namespace MyCashApi.Entities
{
  public class Budget : BaseEntity
  {
    public Budget(List<PiggyBank> piggies, List<Category> categories, Budget basedOn = null)
    {
      StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
      EndDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
      if (basedOn == null) return;

      foreach (var category in categories)
      {
        BudgetEntries.Add(new BudgetEntry());
      }

      foreach (var budgetEntry in basedOn.BudgetEntries.Where(x => x.BudgetEntryType == BudgetEntryType.Default))
      {
        budgetEntry.ActualValue = 0;
        BudgetEntries.Add(budgetEntry);
      }

      foreach (var piggy in piggies)
      {
        BudgetEntries.Add(new BudgetEntry
        {
          ExpectedValue = piggy.DefaultPeriodValue
        });
      }
    }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string Name => $"Budget: {StartDate} - {EndDate}";

    public List<BudgetEntry> BudgetEntries { get; set; } = new List<BudgetEntry>();
  }
}