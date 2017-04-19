using System;
using System.Collections.Generic;
using MyCashApi.Interfaces;
using static System.String;

namespace MyCashApi.Entities
{
  public class Category : SoftDeleteEntity, ICashable
  {
    public Category(string name, List<SubCategory> subCategories, string description = "")
    {
      Name = name;
      Description = IsNullOrEmpty(description) ? name : description;
      SubCategories = subCategories;
      VisibilityOrder = 99;
    }
    public int VisibilityOrder { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<SubCategory> SubCategories { get; set; }
  }
}