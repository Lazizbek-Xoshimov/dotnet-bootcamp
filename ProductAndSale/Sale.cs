namespace ProductAndSale
{
    public class Sale
    {
        public int? Id { get; set; }
        public decimal? Price { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public string ProductColor { get; set; }
    }
}
