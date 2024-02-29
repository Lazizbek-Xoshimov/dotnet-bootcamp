namespace CustomerAndProduct
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Product class bilan birga ko'p bog'lanish;
        /// </summary>
        List<Product> Products { get; set;}
    }
}
