using System;
using System.Collections.Generic;

namespace MyCashApi.Entities
{
  public class Budget : BaseEntity {

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string Name => $"Budget: {StartDate} - {EndDate}";

    public virtual List<BudgetEntry> BudgetEntries { get; set; }
  }
}