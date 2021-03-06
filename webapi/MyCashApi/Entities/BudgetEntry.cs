﻿using System.Collections.Generic;
using MyCashApi.Enums;

namespace MyCashApi.Entities
{
  public class BudgetEntry : BaseEntity
  {
    public Category Category { get; set; }
    public float ExpectedValue { get; set; }
    public float ActualValue { get; set; }
    public float Result { get; set; }
    public string Comment { get; set; }
    public BudgetEntryType BudgetEntryType { get; set; }
    public virtual List<Transaction> Transactions { get; set; }
  }
}