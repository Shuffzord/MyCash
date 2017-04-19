using System;

namespace MyCashApi.Entities
{
  public class Transaction : BaseEntity
  {
    public Transaction()
    {
      TransactionDate = DateTime.Now;
    }
    public BudgetEntry BusinessEntry { get; set; }
    public float Value { get; set; }
    public virtual SubCategory SubCategory { get; set; }
    public Account Account { get; set; }
    public TransactionType TransactionType { get; set; }
    public string Description { get; set; }
    public DateTime TransactionDate { get; set; }
  }
}