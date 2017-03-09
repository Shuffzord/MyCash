using System.ComponentModel.DataAnnotations;

namespace MyCashApi.Entities
{
  public class BaseEntity
  {
    [Key]
    public int Id { get; set; }
  }
}