namespace ShoppingCartDelegate
{
    public class Program
    {
        private static ShoppingCart FillingCart()
        {
            ShoppingCart cart = new ShoppingCart();

            cart.Products.Add(new Product() { Name = "Costume", Price = 70.5M });
            cart.Products.Add(new Product() { Name = "Tshirt", Price = 19.7M });
            cart.Products.Add(new Product() { Name = "Trainers", Price = 20M });
            cart.Products.Add(new Product() { Name = "Socks", Price = 11.5M });
            cart.Products.Add(new Product() { Name = "Trousers", Price = 40M });


            return cart;
        }
        private static decimal CalculateTotalProductPrice(List<Product> products)
        {
            var totalPrice = 0.0M;
            foreach(var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        private static void PrintTotalDiscountAmount(decimal totalPrice, decimal discountPrice)
        {
            Console.WriteLine($"% amunt is: {totalPrice - discountPrice} OFF!");
        }

        public static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { FullName = "Abdusalomov Bahriddin"};
            IUser premiumUser = new PremiumUser() { FullName = "Soliyev Axror" };

            normalUser.Cart = FillingCart();
            premiumUser.Cart = FillingCart();

            decimal normalUserFinalPrice = normalUser.Cart.GetFinalPrice(normalUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($"> {normalUser.FullName} payment: ${normalUserFinalPrice}\n");

            decimal premiumUserFinalPrice = premiumUser.Cart.GetFinalPrice(premiumUser.GetPriceDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($"> {premiumUser.FullName} payment: ${premiumUserFinalPrice}\n");
        }
    }
}