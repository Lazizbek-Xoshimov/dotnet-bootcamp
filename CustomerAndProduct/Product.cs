namespace CustomerAndProduct
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Customer class bilan birga ko'p bog'lanish;
        /// </summary>
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
