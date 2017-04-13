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

        public string Name { get; set; }

        public DateTime Deadline { get; set; }
        public DateTime StartDate { get; set; }

        public float DefaultPeriodValue { get; set; }

        public Interval ExpectedIncomeInterval { get; set; }

        public List<Transaction> Transactions { get; set; }

        public float TargetAmmount { get; set; }

        public float Average
        {
            get { return Transactions.Sum(x => x.Value) / 12; }
        }
    }
}