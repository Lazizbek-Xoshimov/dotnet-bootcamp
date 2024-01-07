using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ShoppingCartDelegate
    {
        public class ShoppingCart
        {
            public List<Product> Products { get; set; } = new List<Product>();

            public delegate decimal GetDiscountPrice(decimal totalPrice);
        
            public decimal GetFinalPrice(
                GetDiscountPrice finalPrice,
                Func<List<Product>, decimal> calculateTotalPrice,
                Action<decimal, decimal> printDiscountAmount
            )
            {
                decimal total = calculateTotalPrice(Products);
                decimal FinalPrice = finalPrice(total);
                printDiscountAmount(total, FinalPrice);

                return FinalPrice;
            }

        }
    }
