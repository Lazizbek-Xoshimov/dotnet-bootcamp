using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDelegate
{
    public class PremiumUser: IUser
    {
        public string FullName {  get; set; }
        public ShoppingCart Cart { get; set; }
        public decimal GetPriceDiscountForUser(decimal totalPrice)
        {
            return totalPrice * (1 - 0.30M);
        }
    }
}
