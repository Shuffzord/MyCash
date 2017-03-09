namespace MyCashApi.Entities
{
  public class Account : BaseEntity
  {

    public string Name { get; set; }

    public string Number { get; set; }

    public AccountType AccountType { get; set; }

    public float IYR { get; set; }

    public float PYR { get; set; }

  }
}