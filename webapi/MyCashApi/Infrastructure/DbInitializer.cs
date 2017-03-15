using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using MyCashApi.Entities;

namespace MyCashApi.Infrastructure
{
  public static class DbInitializer
  {
    static DbInitializer()
    {
      _random = new Random();
    }

    private static readonly Random _random;

    public static void Initialize(Ctx context)
    {
      context.Database.EnsureDeleted();
      context.Database.EnsureCreated();
      var categories = Categories(context);
      Transactions(categories, context);
      context.SaveChanges();
    }

    private static IEnumerable<Category> Categories(Ctx context)
    {
      var categories = new List<Category>
        {
          new Category("Przychody",new List<SubCategory>
          {
              new SubCategory("Całkowite przychody"),
              new SubCategory("Wynagrodzenie"),
              new SubCategory("Premia"),
              new SubCategory("Stan z poprzedniego miesiaca"),
              new SubCategory("Sprzedaż np Allegro"),
              new SubCategory("Inne przychody")
          }),
          new Category("Jedzenie",new List<SubCategory>
          {
              new SubCategory("Jedzenie dom"),
              new SubCategory("Jedzenie miasto"),
              new SubCategory("Jedzenie praca"),
              new SubCategory("Alkohol"),
              new SubCategory("Inne")
          }),
          new Category("Mieszkanie / dom",new List<SubCategory>
          {
              new SubCategory("Czynsz - Sokratesa"),
              new SubCategory("Czynsz - Rostworowskiego"),
              new SubCategory("Prąd"),
              new SubCategory("Wyposażenie"),
              new SubCategory("Ubezpieczenie nieruchomosci"),
              new SubCategory("Składka budżetowa"),
              new SubCategory("Inne")
          }),
          new Category("Transport",new List<SubCategory>
          {
              new SubCategory("Paliwo do auta"),
              new SubCategory("Przeglądy i naprawy auta"),
              new SubCategory("Wyposażenie dodatkowe (opony)"),
              new SubCategory("Bilet komunikacji miejskiej"),
              new SubCategory("Bilet PKP, PKS"),
              new SubCategory("Taxi"),
              new SubCategory("Inne")
          }),
          new Category("Telekomunikacja",new List<SubCategory>
          {
              new SubCategory("Play"),
              new SubCategory("Internet"),
              new SubCategory("Inne"),
          }),
          new Category("Opieka zdrowotna",new List<SubCategory>
          {
              new SubCategory("Lekarz"),
              new SubCategory("Badania"),
              new SubCategory("Lekarstwa"),
              new SubCategory("Inne"),
          }),
          new Category("Ubrania",new List<SubCategory>
          {
              new SubCategory("Ubrania"),
              new SubCategory("Inne")
          }),
          new Category("Higiena",new List<SubCategory>
          {
              new SubCategory("Kosmetyki"),
              new SubCategory("Inne")
          }),
          new Category("Dzieci",new List<SubCategory>
          {

          }),
          new Category("Rozrywka",new List<SubCategory>
          {
              new SubCategory("Siłownia / Basen"),
              new SubCategory("Kino / Teatr"),
              new SubCategory("Koncerty"),
              new SubCategory("Czasopisma"),
              new SubCategory("Książki"),
              new SubCategory("Hobby / Gry"),
              new SubCategory("Hotel / Turystyka"),
              new SubCategory("Inne wydatki")
          }),
          new Category("Firma",new List<SubCategory>
          {
              new SubCategory("ZUS"),
              new SubCategory("Ksiegowosc"),
              new SubCategory("Podatki"),
              new SubCategory("Inne")
          }),
          new Category("Spłata długow",new List<SubCategory>
          {
              new SubCategory("Leasing"),
              new SubCategory("Inne")
          }),
          new Category("Oszczędności",new List<SubCategory>
          {
              new SubCategory("IKZE/IKE"),
              new SubCategory("Garaz"),
              new SubCategory("Fundusz: wakacje"),
              new SubCategory("Fundusz: prezenty"),
              new SubCategory("Konserwacja i naprawy"),
              new SubCategory("Oprogramowanie"),
              new SubCategory("Ubezpieczenie auta"),
              new SubCategory("Inne")
          }),
          new Category("Środki bierzące",new List<SubCategory>
          {
              new SubCategory("Przeniesienie na kolejny miesiac"),
          })
        };
      context.Categories.AddRange(categories);
      return categories;
    }

    private static void Transactions(IEnumerable<Category> categories, Ctx context)
    {
      foreach (var category in categories)
      {
        foreach (var subCategory in category.SubCategories)
        {
          context.Transactions.Add(new Transaction
          {
            Description = $"TestData 1 for {subCategory.Name}",
            SubCategory = subCategory,
            Value = _random.Next(-1000, 1000)
          });
          context.Transactions.Add(new Transaction
          {
            Description = $"TestData 2 for {subCategory.Name}",
            SubCategory = subCategory,
            Value = _random.Next(-1000, 1000)
          });
          context.Transactions.Add(new Transaction
          {
            Description = $"TestData 3 for {subCategory.Name}",
            SubCategory = subCategory,
            Value = _random.Next(-1000, 1000)
          });
        }
      }
    }
  }
}