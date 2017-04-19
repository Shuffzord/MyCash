using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCashApi.Entities;
using MyCashApi.Infrastructure;

namespace MyCashApi.Controllers
{
  [Route("api/[controller]")]
  public class BudgetController : Controller
  {
    private readonly IRepository<Budget> _budgetRepository;
    private readonly IRepository<PiggyBank> _piggiesRepository;
    private readonly IRepository<Category> _categoryRepository;

    public BudgetController(
      IRepository<Budget> budgetRepository,
      IRepository<PiggyBank> piggiesRepository,
      IRepository<Category> categoryRepository)
    {
      _budgetRepository = budgetRepository;
      _piggiesRepository = piggiesRepository;
      _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public IEnumerable<Budget> Get()
    {
      return _budgetRepository.GetAll().ToList();
    }

    [HttpGet]
    public Budget GetCurrent()
    {
      var current = _budgetRepository.Find(x => x.StartDate.Month == DateTime.Now.Month);

      if (current == null)
      {
        var budgetItem = new Budget(
            _piggiesRepository.GetAll().ToList(),
            _categoryRepository.GetAll().Include(x => x.SubCategories).ToList(),
            _budgetRepository.GetAll().OrderByDescending(x => x.StartDate).FirstOrDefault());
        _budgetRepository.Add(budgetItem);
        _budgetRepository.Save();
        return budgetItem;
      }

      return current;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public Budget Get(long id)
    {
      return _budgetRepository.Find(id);
    }
  }
}
