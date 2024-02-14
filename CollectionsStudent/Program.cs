using CollectionsStudent;

namespace CollectionStudent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inson[] talabaMassivi = new Inson[5]
            {
                new Inson("Ali", "Valiyev"),
                new Inson("Vali", "Aliyev"),
                new Inson("Soli", "Soliyev"),
                new Inson("Falonchi", "Falonchiyev"),
                new Inson("Pistonchi", "Pistonchiyev")
            };
            Talaba talabalar = new Talaba(talabaMassivi);
            foreach(var talaba in talabaMassivi)
            {
                Console.WriteLine(talaba.Ism + " " + talaba.Familiya);
            }
        }
    }
}