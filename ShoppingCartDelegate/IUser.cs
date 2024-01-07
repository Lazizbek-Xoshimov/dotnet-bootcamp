using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDelegate
{
    public interface IUser
    {
        string FullName { get; set; }
        ShoppingCart Cart { get; set; }
        decimal GetPriceDiscountForUser(decimal totalPrice);
    }
}
