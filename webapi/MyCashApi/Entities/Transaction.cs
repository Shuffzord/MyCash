namespace MyCashApi.Entities
{
  public class Transaction : BaseEntity
  {
    public float Value { get; set; }
    public Category Category { get; set; }
    public Account Account { get; set; }
    public TransactionType TransactionType { get; set; }
  }
}