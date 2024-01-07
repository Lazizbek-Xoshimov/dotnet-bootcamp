using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDelegate
{
    public class NormalUser: IUser
    {
        public string FullName {  get; set; }
        public ShoppingCart Cart { get; set; }
        public decimal GetPriceDiscountForUser(decimal totalPrice)
        {
            if(Cart.Products.Count > 5) 
            { 
                return totalPrice * (1-0.30M);
            }
            else
            {
                return totalPrice;
            }
        }
    }
}
