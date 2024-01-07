using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public class MoneyManagment
    {
        public void Managment(Money.MoneyDelegate moneyDelegate)
        {
            var money = new Money(0);
            moneyDelegate(money);
        }
        public void DollarToSom(Money money)
        {
            if (money.Currency != "USA")
            {
                System.Console.WriteLine("Changed from dollar to soum...");
                money.Amount *= 12400;
            }
        }
        public void SomToDollar(Money money)
        {
            if (money.Currency != "UZB")
            {
                System.Console.WriteLine("Changed from soum to doller...");
                money.Amount /= 12360;
                money.Currency = "USA";
            }
        }
        public void Send(Money money, string BankName, Money.MoneyDelegate moneyDelegate)
        {
            if (moneyDelegate.Target != null)
            {
                moneyDelegate.Invoke(money);
                System.Console.WriteLine($@"
                                    #########################
                                    Amount: {money.Amount},
                                    Currency: {money.Currency},
                                    Bank Name: {BankName}
                                    #########################");
            }
        }
    }
}
