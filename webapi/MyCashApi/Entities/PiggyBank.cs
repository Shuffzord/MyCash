using System;
using System.Collections.Generic;
using System.Linq;
using MyCashApi.Enums;

namespace MyCashApi.Entities
{
    public class PiggyBank : SoftDeleteEntity
    {
        public PiggyBank(string name)
        {
            Name = name;
            StartDate = DateTime.Now;
        }

        public Category Type { get; set; }

        public string Name { get; set; }
    
        public DateTime StartDate { get; set; }

        public float DefaultPeriodValue { get; set; }

        public float CalculatedPeriodValue { get; set; }  

        public Interval ExpectedIncomeInterval { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Goal Goal { get; set; }
    
    }
}