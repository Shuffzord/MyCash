using static System.String;

namespace MyCashApi.Entities
{
  public class SubCategory : SoftDeleteEntity
  {
    public SubCategory()
    {
    }

    public SubCategory(string name, string description = "")
    {
      Name = name;
      Description = IsNullOrEmpty(description) ? name : description;
    }

    public string Name { get; set; }

    public string Description { get; set; }
  }
}