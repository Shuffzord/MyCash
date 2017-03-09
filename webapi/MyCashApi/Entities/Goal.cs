using System;

namespace MyCashApi.Entities
{
  public class Goal : SoftDeleteEntity
  {
    public Category Category { get; set; }
    public Category Account { get; set; }

    public float Value { get; set; }

    public DateTime Deadline { get; set; }

    public bool Recurring { get; set; }

    public string ReccurringPattern { get; set; }
  }
}