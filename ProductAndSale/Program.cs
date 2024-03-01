using ProductAndSale;

var products = GetProducts();
var sales = GetSales();

//var resultByMethod = products.Join(sales,
//                                    product => product.Id,
//                                    sale => sale.ProductId,
//                                    (product, sale) => new ProductSale
//                                    {
//                                        ProductId = product.Id,
//                                        SaleId = sale.Id,
//                                        Name = product.Name,
//                                        Price = sale.Price
//                                    });

//var resultByQuery = (from product in products
//                     join sale in sales on product.Id equals sale.ProductId
//                     select new ProductSale
//                     {
//                         ProductId = product.Id,
//                         SaleId = sale.Id,
//                         Name = product.Name,
//                         Price = sale.Price
//                     }).ToList();

//var resultByMethod2 = products.Join(sales,
//                                    product => new { ProductId = product.Id, ProductColor = product.Color },
//                                    sale => new { ProductId = sale.ProductId, ProductColor = sale.ProductColor },
//                                    (product, sale) => new ProductSale
//                                    {
//                                        ProductId = product.Id,
//                                        SaleId = sale.Id,
//                                        Name = product.Name,
//                                        Price = sale.Price,
//                                        Color = product.Color
//                                    }).ToList();

//foreach (var result in resultByMethod2)
//{
//    Console.WriteLine(result.Name, result.Price, result.SaleId, result.Color);
//}

//var numbers = new List<int>() { 35, 36, 21, 342, 125, 56, 53, 91 };
//var querySyntax = from number in numbers
//                  group number by number % 2;

//foreach (var group in querySyntax )
//{
//    Console.WriteLine(group.Key == 0 ? "\nJuft sonlar: " : "\nToq sonlar: ");
//    foreach ( var item in group )
//    {
//        Console.WriteLine(item);
//    }
//}

//var querySyntaxResult = (from product in  products
//                         group product by product.Color).ToList();
//foreach (var item in querySyntaxResult)
//{
//    foreach(var value in item)
//    {
//        Console.WriteLine(value.Name);
//    }
//}

var resultByMethod1 = products.Join(sales,
                                    product => product.Id,
                                    sale => sale.ProductId,
                                    (product, sale) => new ProductSale
                                    {
                                        ProductId = product.Id,
                                        SaleId = sale.Id,
                                        Name = product.Name,
                                        Price = sale.Price,
                                    }).ToList();

var resultByMethod2 = products.Join(sales,
                                    product => new { ProductId = product.Id, ProductColor = product.Color },
                                    sale => new { ProductId = sale.ProductId, ProductColor = sale.ProductColor },
                                    (product, sale) => new ProductSale
                                    {
                                        ProductId = product.Id,
                                        SaleId = sale.Id,
                                        Name = product.Name,
                                        Price = sale.Price,
                                        Color = product.Color,
                                    }).ToList();

var resultQuery1 = (from product in products
                    join sale in sales on product.Id equals sale.ProductId
                    select new ProductSale
                    {
                        ProductId = product.Id,
                        SaleId = sale.Id,
                        Name = product.Name,
                        Price = sale.Price
                    }).ToList();

var resultByQuery2 = (from product in products
                      join sale in sales on
                      new {ProductId = product.Id, ProductColor = product.Color}
                      equals
                      new {ProductId = sale.ProductId, ProductColor = sale.ProductColor}
                      select new ProductSale
                      {
                          ProductId= product.Id,
                          SaleId= sale.Id,
                          Name = product.Name,
                          Price = sale.Price,
                          Color = product.Color,
                      }).ToList();

//foreach (var item in resultByQuery2)
//{
//    Console.WriteLine(item.Name, item.SaleId, item.ProductId, item.Price);
//}

var groupJoinQuery1 = products.GroupJoin(sales,
                                        product => product.Id,
                                        sale => sale.ProductId,
                                        (productX, saleX) => new { productX, saleX });

var groupJoinQuery2 = products.GroupJoin(sales,
                                        product => new { ProductId = product.Id, ProductColor = product.Color },
                                        sale => new { ProductId = sale.ProductId, ProductColor = sale.ProductColor },
                                        (productX, saleX) => new { productX, saleX });

var groupJoinMethod1 = from product in products
                       join sale in sales on product.Id equals sale.Id into saleGroup
                       select new {productX = product, saleX = saleGroup };

var groupJoinMethod2 = from product in products
                       join sale in sales on
                       new {ProductId = product.Id, ProductColor = product.Color}
                       equals
                       new {ProductId = sale.ProductId, ProductColor = sale.ProductColor}
                       into saleGroup
                       select new {productX = product, saleX = saleGroup};

//foreach (var groupJoin in groupJoinQuery1)
//{
//    Console.WriteLine($"{groupJoin.productX.Name}");
//    foreach (var item in groupJoin.saleX)
//    {
//        Console.WriteLine($"{item.Price} - {item.ProductColor}");
//    }
//    Console.WriteLine();
//}

var resultByQuery = products.SelectMany(product => sales.Where(sale => sale.ProductId == product.Id).DefaultIfEmpty(),
                      (product, sale) => new ProductSale
                      {
                          SaleId = sale?.Id,
                          ProductId = product.Id,
                          Name = product.Name,
                          Price = sale?.Price,
                          Color = sale?.ProductColor
                      }).ToList();

var resultByMethod = (from product in products
                      join sale in sales
                      on product.Id equals sale.ProductId
                      into productSales
                      from sale in productSales.DefaultIfEmpty()
                      select new ProductSale
                      {
                          SaleId = sale?.Id,
                          ProductId = product.Id,
                          Name = product.Name,
                          Color = sale?.ProductColor,
                          Price = sale?.Price,
                      }).ToList();

foreach (var item in resultByQuery)
{
    Console.WriteLine($"{item.ProductId}, {item.SaleId}, {item.Name}, {item.Price}, {item.Color} \n");
}

static List<Sale> GetSales()
{
    var sales = new List<Sale>()
    {
        new Sale { Id = 100, Price = 10, ProductId = 1, ProductColor = "Qora" },
        new Sale { Id = 101, Price = 10, ProductId = 1, ProductColor = "Ko'k" },
        new Sale { Id = 102, Price = 12, ProductId = 10, ProductColor = "Pushti" },
        new Sale { Id = 103, Price = 10, ProductId = 1, ProductColor = "Sabzirang" },
        new Sale { Id = 104, Price = 6, ProductId = 8, ProductColor = "Qizil" },
        new Sale { Id = 105, Price = 5, ProductId = 12, ProductColor = "Binafsharang" },
        new Sale { Id = 106, Price = 10, ProductId = 2, ProductColor = "Oq" },
        new Sale { Id = 107, Price = 6, ProductId = 8, ProductColor = "Jigarrang" },
        new Sale { Id = 108, Price = 10, ProductId = 1, ProductColor = "Pushti" },
        new Sale { Id = 109, Price = 99, ProductId = 9, ProductColor = "Qora" },
        new Sale { Id = 110, Price = 25, ProductId = 6, ProductColor = "Qora" },
        new Sale { Id = 111, Price = 25, ProductId = 6, ProductColor = "Oq" },
        new Sale { Id = 112, Price = 7, ProductId = 13, ProductColor = "Kulrang" },
        new Sale { Id = 113, Price = 55, ProductId = 5, ProductColor = "Qo'ng'ir" },
        new Sale { Id = 114, Price = 55, ProductId = 5, ProductColor = "Qora" },
        new Sale { Id = 115, Price = 5, ProductId = 12, ProductColor = "Qora" },
        new Sale { Id = 116, Price = 10, ProductId = 1, ProductColor = "Qora" },
        new Sale { Id = 117, Price = 4, ProductId = 3, ProductColor = "Qora" },
        new Sale { Id = 118, Price = 12, ProductId = 10, ProductColor = "Qora" },
        new Sale { Id = 119, Price = 13, ProductId = 4, ProductColor = "Kulrang" },
        new Sale { Id = 120, Price = 8, ProductId = 7, ProductColor = "Yashil" },
        new Sale { Id = 121, Price = 10, ProductId = 1, ProductColor = "Qora" },
        new Sale { Id = 122, Price = 6, ProductId = 2, ProductColor = "Qora" },
    };

    return sales;
}

static List<Product> GetProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 1, Name = "Futbolka", Color = "Ko'k" },
        new Product { Id = 2, Name = "Mayka", Color = "Oq" },
        new Product { Id = 3, Name = "Paypoq", Color = "Qora" },
        new Product { Id = 4, Name = "Sho'rtik", Color = "Kulrang" },
        new Product { Id = 5, Name = "Shim", Color = "Qo'ng'ir" },
        new Product { Id = 6, Name = "Tufli", Color = "Qora" },
        new Product { Id = 7, Name = "Sharf", Color = "Yashil" },
        new Product { Id = 8, Name = "Krassovka", Color = "Qizil" },
        new Product { Id = 9, Name = "Kostyum", Color = "Qora" },
        new Product { Id = 10, Name = "Xalat", Color = "Pushti" },
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq" },
        new Product { Id = 12, Name = "Bo'yinbog'", Color = "Binafsharang" },
        new Product { Id = 13, Name = "Kepka", Color = "Kulrang" },
    };

    return products;
}