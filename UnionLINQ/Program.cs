using ProductAndSale;
using UnionLINQ;

//var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, };
//var list2 = new List<int>() { 4, 5, 6 };
//var methodSyntax = list1.Union(list2).ToList();
//methodSyntax.ForEach(x => Console.WriteLine(x));

var products = GetProducts();
var anotherProducts = GetAnotherProducts();
ProductCompare comparer = new();

//var resultByMethod = products.Union(anotherProducts, comparer).ToList();
//foreach (var product in resultByMethod)
//{
//    Console.WriteLine($"{product.Id}, {product.Name}, {product.Color}");
//}

static List<Product> GetProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 1, Name = "Futbolka", Color = "Ko'k", Price = 15, Quantity = 23 },
        new Product { Id = 2, Name = "Mayka", Color = "Oq", Price = 10, Quantity = 43 },
        new Product { Id = 3, Name = "Paypoq", Color = "Qora", Price = 4, Quantity = 32 },
        new Product { Id = 4, Name = "Sho'rtik", Color = "Kulrang", Price = 23, Quantity = 19 },
        new Product { Id = 5, Name = "Shim", Color = "Qo'ng'ir", Price = 54, Quantity = 53 },
        new Product { Id = 6, Name = "Tufli", Color = "Qora", Price = 37, Quantity = 52 },
        new Product { Id = 7, Name = "Sharf", Color = "Yashil", Price = 26, Quantity = 101 },
        new Product { Id = 8, Name = "Krassovka", Color = "Qizil", Price = 61, Quantity = 202 },
        new Product { Id = 9, Name = "Kostyum", Color = "Qora", Price = 121, Quantity = 39 },
        new Product { Id = 10, Name = "Xalat", Color = "Pushti", Price = 49, Quantity = 62 },
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq", Price = 32, Quantity = 98 },
        new Product { Id = 12, Name = "Bo'yinbog'", Color = "Binafsharang", Price = 14, Quantity = 21 },
        new Product { Id = 13, Name = "Kepka", Color = "Kulrang", Price = 11, Quantity = 46 },
    };
    return products;
}

static List<Product> GetAnotherProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 7, Name = "Sharf", Color = "Yashil", Price = 24, Quantity = 23 },
        new Product { Id = 8, Name = "Krassovka", Color = "Qizil", Price = 63, Quantity = 86 },
        new Product { Id = 9, Name = "Kostyum", Color = "Qora", Price = 134, Quantity = 42 },
        new Product { Id = 10, Name = "Xalat", Color = "Pushti", Price = 47, Quantity = 71 },
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq", Price = 30, Quantity = 39 },
        new Product { Id = 12, Name = "Bo'yinbog'", Color = "Binafsharang", Price = 11, Quantity = 89 },
        new Product { Id = 13, Name = "Kepka", Color = "Kulrang", Price = 13, Quantity = 40 },
        new Product { Id = 14, Name = "Futbolka", Color = "Ko'k", Price = 16, Quantity = 32 },
        new Product { Id = 15, Name = "Mayka", Color = "Oq", Price = 19, Quantity = 45 },
        new Product { Id = 16, Name = "Paypoq", Color = "Qora", Price = 7, Quantity = 64 },
        new Product { Id = 17, Name = "Sho'rtik", Color = "Kulrang", Price = 20, Quantity = 3 },
        new Product { Id = 18, Name = "Shim", Color = "Qo'ng'ir", Price = 53, Quantity = 35 },
        new Product { Id = 19, Name = "Tufli", Color = "Jigarrang", Price = 31, Quantity = 93 },
    };

    return products;
}

var query = products.Union(anotherProducts);
//foreach (var item in query)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}

var count = query.Count(p => p.Color == "Qora");
//Console.WriteLine("Count: " + count);

var min = query.Select(p => p.Price).Min();
//Console.WriteLine("Min: " + min);

var minBy = query.MinBy(p => p.Price);
//Console.WriteLine("MinBy name: " + minBy.Name);

var max = query.Select(p => p.Price).Max();
//Console.WriteLine("Max: " + max);

var maxBy = query.MaxBy(p => p.Price);
//Console.WriteLine("MaxBy name: " + maxBy.Name);

/// <summary>
/// Average - o'rtacha qiymatini hisoblab beradi;
/// </summary>
var average1 = query.Select(p => p.Price).Average();
//Console.WriteLine("Average1: " + average1);

var average2 = query.Average(p => p.Price);
//Console.WriteLine("Average2: " + average2);

var sum1 = query.Select(p => p.Price).Sum();
//Console.WriteLine("Sum1: " + sum1);

var sum = query.Sum(p => p.Price);
//Console.WriteLine($"Sum2: {sum2}");

/// <summary>
/// aggregate - birlashmasini hisoblab beradi;
/// </summary>
var aggregate = query.Aggregate(0m, (sum, product) => sum += product.Price * product.Quantity);
//Console.WriteLine("Aggregate: " + aggregate);

//query.ForEach(p =>
//{
//    var tmp = p.TotalStock = (int)p.Price * p.Quantity;
//    Console.WriteLine(tmp);
//});

//query.ForEach(p => p.TotalStock = p.Quantity * (int)p.Price);

//var result = (from p in query
//              let tmp = p.TotalStock = (int)p.Price * p.Quantity
//              select p).ToList();

List<int> list = new() { 1, 2, 3, 4, 5, 6 };
List<int> anotherList = new() { 1, 2, 3, 4, 5 };

/// <summary>
/// sequenceEqual - ikkita to'plamni aynan tenglikka tekshiradi;
/// </summary>
var querySequenseEqual = list.SequenceEqual(anotherList);
//Console.WriteLine(querySequenseEqual);


ProductIdComparer idComparer = new();
var product = products.Last();

var queryUnion = products.Union(anotherProducts, comparer).ToList();
foreach (var item in query)
{
    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
}
Console.WriteLine();

/// <summary>
/// Contains - bor yoki yo'qligini tekshiradi;
/// </summary>
//var result2 = query.Select(p => p.Color).Contains("Sabzirang");
var result2 = query.Contains(product, idComparer);
//Console.WriteLine(result2);

var productsId = new List<int>() { 1, 2, 3, 4, 5, 6 };

var surov = products.ExceptBy(productsId, product => product.Id).ToList();
//foreach (var item in surov)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}

var queryExcept = anotherList.Except(list).ToList();

//foreach (var item in queryExcept)
//    Console.WriteLine(item);

var productIds = new List<int>() { 1, 2, 3, 4, 5, 6 };

var result = query.IntersectBy(productIds, product => product.Id).ToList();

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}

var surovIntersect = list.Intersect(anotherList).ToList();

foreach (var item in surovIntersect)
    Console.WriteLine(item);