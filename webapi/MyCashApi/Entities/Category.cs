namespace MyCashApi.Entities
{
  public class Category : SoftDeleteEntity {
    public string Code { get; set; }
    public string Description { get; set; }
  }
}