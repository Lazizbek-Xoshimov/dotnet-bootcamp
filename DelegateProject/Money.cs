using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public class Money
    {
        public decimal Amount { get; set; } = 0;
        public string Currency { get; set; } = "";
        public delegate void MoneyDelegate(Money money);

        public Money(decimal Amount)
        {
            this.Amount = Amount;
            this.Currency = "UZB";
        }

    }
}
