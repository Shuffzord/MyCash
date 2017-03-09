namespace MyCashApi.Entities
{
  public class SoftDeleteEntity : BaseEntity
  {
    public bool IsDeleted { get; set; }
  }
}