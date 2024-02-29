using CustomerAndProduct;

List<Customer> customers = new List<Customer>()
{
    new Customer(){Id = 1, CustomerName = "Sardor", CustomerAddress = "Toshkent", PhoneNumber = "94 395 04 55"},
    new Customer(){Id = 2, CustomerName = "Akmal", CustomerAddress = "Farg'ona", PhoneNumber = "93 223 63 82"},
    new Customer(){Id = 3, CustomerName = "Akbar", CustomerAddress = "Samarqand", PhoneNumber = "91 625 82 92"},
    new Customer(){Id = 4, CustomerName = "Ilhom", CustomerAddress = "Sirdaryo", PhoneNumber = "90 522 82 94"},
    new Customer(){Id = 5, CustomerName = "Bahodir", CustomerAddress = "Toshkent", PhoneNumber = "90 624 95 42"},
    new Customer(){Id = 6, CustomerName = "Said", CustomerAddress = "Qashqadaryo", PhoneNumber = "50 517 00 42"},
};

List<Product> products = new List<Product>()
{
    new Product(){Id = 1, ProductName = "Kettle", UnitPrice = 14.0m, CustomerId = 6},
    new Product(){Id = 2, ProductName = "Lamp", UnitPrice = 24.0m, CustomerId = 2},
    new Product(){Id = 3, ProductName = "Lock", UnitPrice = 30.0m, CustomerId = 1},
    new Product(){Id = 4, ProductName = "Hammer", UnitPrice = 6.0m, CustomerId = 4},
    new Product(){Id = 5, ProductName = "Fan", UnitPrice = 8.0m, CustomerId = 5},
    new Product(){Id = 6, ProductName = "Mug", UnitPrice = 11.0m, CustomerId = 3},
    new Product(){Id = 7, ProductName = "Hearth", UnitPrice = 30.0m, CustomerId = 4},
    new Product(){Id = 8, ProductName = "Dryer", UnitPrice = 25.0m, CustomerId = 2},
    new Product(){Id = 9, ProductName = "Gate", UnitPrice = 33.0m, CustomerId = 1},
};

/// CustomerName, CustomerAddress, CustomerPhoneNumber, ProductName, ProductUnitPrice
var query = (from c in customers
            join p in products on c.Id equals p.CustomerId
            select new { c.CustomerName, c.CustomerAddress, c.PhoneNumber, p.UnitPrice, p.ProductName});
Console.WriteLine("Query bo'yicha: ");
foreach (var item in query)
{
    Console.WriteLine($"Ismi: {item.CustomerName}, Manzili: {item.CustomerAddress}, Telefon raqami: {item.PhoneNumber}," +
        $" Mahsulot nomi: {item.ProductName}, mahsulot narxi: {item.UnitPrice} $");
}

///Method ko'rinishida:
var queryMethod = customers.Join(products,
                            c => c.Id,
                            p => p.CustomerId,
                            (c, p) => new { c.CustomerName, c.CustomerAddress, c.PhoneNumber, p.ProductName, p.UnitPrice });
Console.WriteLine("\nMethod bo'yicha: ");
foreach (var item in queryMethod)
{
    Console.WriteLine($"Ismi: {item.CustomerName}, Manzili: {item.CustomerAddress}, Telefon raqami: {item.PhoneNumber}," +
        $" Mahsulot nomi: {item.ProductName}, mahsulot narxi: {item.UnitPrice} $");
}