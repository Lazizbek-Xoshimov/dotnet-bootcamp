using LINQMethods;

var markets = new List<Market>()
{
    new Market() { Id = 1, Name = "Korzinka", Items = new string[] { "kiwi", "cherry", "banana" } },
    new Market() { Id = 2, Name = "Macro", Items = new string[] { "melon", "mango", "olive" } },
    new Market() { Id = 3, Name = "Azia", Items = new string[] { "kiwi", "apple", "orange" } },
    new Market() { Id = 4, Name = "Andalus", Items = new string[] { "grape", "watermelon", "pomegranate" } },
    new Market() { Id = 5, Name = "Havas", Items = new string[] { "avacado", "pineapple", "papaya" } },
    new Market() { Id = 6, Name = "Baraka", Items = new string[] { "pear", "lemon", "plum" } },
};

/// <summary>
/// All da hammasi shartni qanoatlantirishi kerak;
/// </summary>
var names = (from market in markets
             where market.Items.All(item => item.Length == 5)
             select market.Name).ToList();   

var namesQuery = markets.Where(market => market.Items.All(item => item.Length == 5))
                        .Select(market => market.Name).ToList();
//namesQuery.ForEach(x => Console.Write(x));

/// <summary>
/// Any da hech bo'lmaganda bittasi shartni qanoatlantirishi kerak;
/// </summary>
var names2 = (from market in markets
              where market.Items.Any(item => item.Length == 5)
              select market.Name).ToList();

var namesQuery2 = markets.Where(market => market.Items.Any(item => item.Length == 5))
                        .Select(market => market.Name).ToList();
//namesQuery2.ForEach(x => Console.WriteLine(x));

var newMarkets = markets.Where(m => m.Items.Any(i => i.Length == 5))
                        .Select(m => new Market
                        {
                            Id = m.Id,
                            Name = m.Name + " market",
                            Items = m.Items,
                        }).ToList();
//newMarkets.ForEach(m =>
//{
//    Console.WriteLine($"{m.Id}. {m.Name}: ");
//    Array.ForEach(m.Items, i => Console.WriteLine(i));
//    Console.WriteLine();
//});

var otherMarkets = new List<Market>()
{
    new Market() { Id = 1, Name = "Korzinka", Items = new string[] { "kiwi, cherry, banana", "shirt, jacket, trousers", "bread, cake, toast" } },
    new Market() { Id = 2, Name = "Macro", Items = new string[] { "melon, manga, olive", "jumper, coat, jeans", "sandwich, biscuit, cookies" } },
    new Market() { Id = 3, Name = "Azia", Items = new string[] { "kiwi, apple, orange", "sweatshirt, t-shirt, polo shirt", "bagel, roll, pie" } },
    new Market() { Id = 4, Name = "Andalus", Items = new string[] { "grape, watermelon, pomegranate", "suit, hoodie, dress", "pancake, crackers, doughnuts" } },
    new Market() { Id = 5, Name = "Havas", Items = new string[] { "avacado, pineapple, papaya", "skirts, boxers, cap", "lavash, hamburger, kebab" } },
    new Market() { Id = 6, Name = "Baraka", Items = new string[] { "pear, lemon, plum", "hat, slippers, tie", "hotdog, cheeseburger, burger" } },
};

/// <summary>
/// OrderBy - berilgan shart bo'yicha sortlaydi;
/// </summary>
var otherNewMarkets = from market in otherMarkets
                      from items in market.Items
                      from item in items.Split(',')
                      orderby item.Length
                      select item;
//foreach (var obj in otherNewMarkets)
//{
//    Console.WriteLine(obj);
//}

var phrases = new List<string>() { "an apple a day", "the quick brown fox" };

/// <summary>
/// SelectMany - ichma ich select;
/// </summary>
var query2 = phrases.SelectMany(p => p.Split(' '));

var surov = from phrase in phrases
            from word in phrase.Split(' ')
            select word;

foreach (var item in surov) Console.WriteLine(item);