using ProductAndSale;
using System.Collections;
using UnionLINQ;

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

var products = GetProducts();
var anotherProducts = GetAnotherProducts();
ProductIdComparer comparer = new();

/// <summary>
/// Union - birlashtiradi;
/// </summary>
var query = products.Union(anotherProducts, comparer).ToList();
foreach (var item in query)
{
    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
}
Console.WriteLine();

/// <summary>
/// ElementAt - ko'rsatilgan index'dagi elementni olib beradi;
/// </summary>
//Console.WriteLine("---------------------------ELEMENTAT---------------------------------");
var result1 = query.ElementAt(3);
//Console.WriteLine($"{result1.Id}, {result1.Name}, {result1.Color}, {result1.Price}, {result1.Quantity}");

/// <summary>
/// ElementAtOrDefault - ko'rsatilgan index'dagi elementni oladi, aks holda default qiymatini qaytaradi;
/// </summary>
//Console.WriteLine("---------------------------ELEMENTATORDEFAULT---------------------------------");
var result2 = query.ElementAtOrDefault(19);
//Console.WriteLine($"{result2?.Id}, {result2?.Name}, {result2?.Color}, {result2?.Price}, {result2?.Quantity}");

ArrayList arrayList = new ArrayList()
{
    10, 20, 30,
};
arrayList.Add(40);
/// <sumary>
/// Cast - Type'si umumiy bo'lmagan collection'ni bir xil umumiy type'ga o'tkazadi;
/// </sumary>
IEnumerable<int> result = arrayList.Cast<int>();
//foreach (int item in result) Console.WriteLine(item);

/// <summary>
/// ToHashSet - collection'dan bir xil elementlarni chopib yuboradi;
/// </summary>
List<int> list = new List<int>() { 1, 2, 3, 3, 4, 5 };
var set = list.ToHashSet();
//foreach (int item in set) Console.WriteLine(item);

/// <summary>
/// ToLookUp - GroupBy'ga o'xshab ko'rsatilgan shart bo'yicha guruhlaydi;
/// </summary>
//Console.WriteLine("--------------------------- TOLOOKUP ---------------------------------");
var resultToLookUp = query.ToLookup(p => p.Name).ToList();
//foreach (var group in resultToLookUp)
//{
//    Console.WriteLine(group.Key + " : " + group.Count() + " ta");

//    foreach (var item in group)
//    {
//        Console.WriteLine($"{item.Id}, {item.Color}, {item.Price}, {item.Quantity}");
//    }
//    Console.WriteLine();
//}

/// <summary>
/// AsEnumerable - Enumerable type'siga o'takazadi;
/// </summary>
//Console.WriteLine("--------------------------- AsEnumerable ---------------------------------");
var resultAsEnumerable = query.AsEnumerable();
//foreach (var item in resultAsEnumerable) Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");

//List<int> list = new List<int> { 10, 20, 30, 40 };
//var append = list.Append(50);

/// <summary>
/// Enumerable.Range - ko'rsatilgan oraliqdagi sonlarni iteratsiya qilib beradi;
/// </summary>
var ketmaKetlik = Enumerable.Range(1, 10).Where(x => x % 2 == 0);
//foreach (var item in ketmaKetlik) Console.WriteLine(item);

/// <summary>
/// Enumerable.Repeat - ko'rsatilgan elementni takrorlab beradi;
/// </summary>
var takror = Enumerable.Repeat("Dars qilinglar-ey?!", 5).ToList();
//foreach(var item in takror) Console.WriteLine(item);

/// <summary>
/// Enumerable.Reverse - ko'rsatilgan collection'ni teskari tartibga o'girib beradi;
/// </summary>
var numbers = new List<int>() { 1, 2, 3 };
var teskari = Enumerable.Reverse(numbers).ToList();
//foreach (var item in teskari) Console.WriteLine(item);

/// <summary>
/// Enumerable.Empty - bo'sh ketma ketlikni hosil qiladi;
/// </summary>
var resultEmpty = Enumerable.Empty<int>();
//Console.WriteLine("Empty: " + resultEmpty.Count());
var natijaEmpty = Enumerable.Empty<Product>();
//Console.WriteLine("GetType: " + natijaEmpty.GetType());

/// <summary>
/// OfType - Collection'dan ma'lum type'dagi malumotlarni tanlab oladi;
/// </summary>
var dataSource = new List<object>()
{
    "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
};
var intData = dataSource.OfType<string>().ToList();
//foreach(var item in intData) Console.WriteLine(item);

/// <summary>
/// Prepend - Collection'ga boshidan boshlab element qo'shib beradi;
/// </summary>
var resultPrepend = list.Prepend(50);
//foreach (var item in resultPrepend) Console.WriteLine(item);

/// <summary>
/// Zip(zamok) - ikki yoki undan ortiq elementlarni mos ketma ketlikda birlashtiradi;
/// </summary>
int[] numbers1 = { 10, 20, 30, 40, 50 };
string[] words1 = { "Ten", "Twenty", "Thirty", "Fourty" };
var resultZip = numbers1.Zip(words1, (first, second) => first + " " + second);
//foreach (var item in resultZip) Console.WriteLine(item);

/// <summary>
/// Take - collection boshidan elementlarni olish uchun ishlatiladi;
/// </summary>
//Console.WriteLine("---------------- TAKE -------------\n");
var resultTake1 = query.Take(3).ToList();
// Bunday xollarda ko'rsatilgan index'dan boshlab element oladi;
var resultTake2 = query.Take(3..).ToList();
//foreach (var item in resultTake2)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}


/// <summary>
/// TakeWhile - ko'rsatilgan shart bajarilgunigacha elementlarni qaytaradi;
/// </summary>
//Console.WriteLine("---------------- TAKEWHILE -------------\n");
var resultTakeWhile = query.TakeWhile(p => p.Quantity < 50).ToList();
//foreach (var item in resultTakeWhile)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}

/// <summary>
/// TakeLast - oxiridan boshlab ko'rsatilgan count'cha element oladi;
/// </summary>
//Console.WriteLine("---------------- TAKELAST -------------\n");
var resultTakeLast = query.TakeLast(3).ToList();
//foreach (var item in resultTakeLast)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}


/// <summary>
/// Skip - Take'ni antonimi yani boshidan count'cha elementdan boshqalarini oladi;
/// </summary>
//Console.WriteLine("---------------- SKIP -------------\n");
var resultSkip = query.Skip(3).ToList();
//foreach (var item in resultSkip)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}

/// <summary>
/// SkipWhile - TakeWhile'ni antonimi, yani shartni qabul qilsa chopib yuboraveradi;
/// </summary>
//Console.WriteLine("---------------- SKIPWHILE -------------\n");
var resultSkipWhile = query.SkipWhile(p => p.Name.StartsWith("K")).ToList();
//foreach (var item in resultSkipWhile)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
//}

/// <summary>
/// SkipLast - oxiridan count'cha elementlarni chopib yuboradi(o'tkazib yuboradi);
/// </summary>
Console.WriteLine("---------------- SKIPLAST -------------\n");
var resultSkipLast = query.SkipLast(3).ToList();
foreach (var item in resultSkipLast)
{
    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}, {item.Price}, {item.Quantity}");
}