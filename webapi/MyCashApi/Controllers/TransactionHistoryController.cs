using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyCashApi.Entities;
using MyCashApi.Infrastructure;

namespace MyCashApi.Controllers
{
    [Route("api/[controller]")]
    public class TransactionHistoryController : Controller
    {
        private readonly IRepository<Transaction> transactionRepository;

        public TransactionHistoryController(IRepository<Transaction> transactionRepository)
        {
            this.transactionRepository = transactionRepository;

        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return this.transactionRepository.GetAll().ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
