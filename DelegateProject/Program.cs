using DelegateProject;

namespace DelegateMoneyManagment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var money = new Money(10000);
            var moneyManagment = new MoneyManagment();

            Money.MoneyDelegate moneyDelegate = moneyManagment.DollarToSom;
            // moneyDelegate += moneyManagment.SomToDollar;

            moneyManagment.Send(money, "KapitalBank", moneyDelegate);
            // moneyManagment.Managment(moneyDelegate);
        }
    }
}