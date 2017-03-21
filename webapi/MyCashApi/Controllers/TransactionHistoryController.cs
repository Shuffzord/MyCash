using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCashApi.Entities;
using MyCashApi.Infrastructure;

namespace MyCashApi.Controllers
{
  [Route("api/[controller]")]
  public class TransactionHistoryController : Controller
  {
    private readonly IRepository<Transaction> _transactionRepository;

    public TransactionHistoryController(IRepository<Transaction> transactionRepository)
    {
      this._transactionRepository = transactionRepository;

    }
    // GET api/values
    [HttpGet]
    public IEnumerable<Transaction> Get()
    {
      return _transactionRepository.GetAll().Include(x => x.SubCategory).ToList();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public Transaction Get(long id)
    {
      return _transactionRepository.Find(id);
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]Transaction item)
    {
      _transactionRepository.Add(item);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put([FromBody]Transaction item)
    {
      _transactionRepository.Update(item);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(long id)
    {
      _transactionRepository.Remove(_transactionRepository.Find(id));
    }
  }
}
