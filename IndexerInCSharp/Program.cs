namespace IndexerInCSharp
{
    public class Program
    {
        private static object xodim;

        public static void Main(string[] args)
        {
            //var indexer = new IndexerXosilQilish();
            //indexer[0] = 30;
            //indexer[1] = 40;
            //indexer[2] = 20;
            //indexer[3] = 10;

            //Console.WriteLine("Indexer qiymatlari: ");
            //for(int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Indekser[{0}] = {1}", i, indexer[i]);
            //}

            //var xodim1 = new Xodim(1, "Ibrat", "Ibrohimov", "01.01.2004", "Erkak", "Arab", "+998 99 999 12 12", "helloworld@mail.ru", 2000);
            //var xodim2 = new Xodim(2, "Javohir", "Zaifjonov", "21.03.2012", "Erkak", "Rus", "+998 99 123 22 41", "salomdunyo@email.com", 3000);
            //var xodim3 = new Xodim(3, "Sardor", "Safarov", "31.12.2000", "Erkak", "Tatar", "+998 93 221 45 75", "sardordasturchi@mail.ru", 4100);
            //var xodim4 = new Xodim(4, "Jasur", "Aliyev", "24.10.2001", "Erkak", "Kores", "+998 88 813 51 85", "jasur001@mail.ru", 5000);
            //var xodimlar = new List<Xodim>() { xodim1, xodim2, xodim3, xodim4 };

            //xodimlar.PrintAllConsole();


            var genericXodim1 = new GenericXodim<string> ();
            genericXodim1[0] = "1";
            genericXodim1[1] = "Ibrat";
            genericXodim1[2] = "Ibrohimov";
            genericXodim1[3] = "01.01.2004";
            genericXodim1[4] = "Erkak";
            genericXodim1[5] = "Arab";
            genericXodim1[6] = "+998 99 999 12 12";
            genericXodim1[7] = "helloworld@mail.ru";
            genericXodim1[8] = "2000";

            var genericXodim2 = new GenericXodim<string> ();
            genericXodim2[0] = "2";
            genericXodim2[1] = "Javohir";
            genericXodim2[2] = "Zaifjonov";
            genericXodim2[3] = "21.03.2012";
            genericXodim2[4] = "Erkak";
            genericXodim2[5] = "Rus";
            genericXodim2[6] = "+998 99 123 22 41";
            genericXodim2[7] = "salomdunyo@email.com";
            genericXodim2[8] = "3000";

            var genericXodim3 = new GenericXodim<string> ();
            genericXodim3[0] = "3";
            genericXodim3[1] = "Sardor";
            genericXodim3[2] = "Safarov";
            genericXodim3[3] = "31.12.2000";
            genericXodim3[4] = "Erkak";
            genericXodim3[5] = "Tatar";
            genericXodim3[6] = "+998 93 221 45 75";
            genericXodim3[7] = "sardordasturchi@mail.ru";
            genericXodim3[8] = "4100";

            var genericXodim4 = new GenericXodim<string> ();
            genericXodim4[0] = "4";
            genericXodim4[1] = "Jasur";
            genericXodim4[2] = "Aliyev";
            genericXodim4[3] = "24.10.2001";
            genericXodim4[4] = "Erkak";
            genericXodim4[5] = "Kores";
            genericXodim4[6] = "+998 88 813 51 85";
            genericXodim4[7] = "jasur001@mail.ru";
            genericXodim4[8] = "5000";

            var genericXodimlar = new List<GenericXodim<string>>() { genericXodim1, genericXodim2, genericXodim3, genericXodim4 };
            genericXodimlar.PrintAllGenericConsole();

            //Console.WriteLine("ID = " + xodim[0]);
            //Console.WriteLine("Ismi" + xodim[1);
            //Console.WriteLine("Familiyasi" + xodim[2]);
            //Console.WriteLine("Tugulgan sanasi = " + xodim[3]);
            //Console.WriteLine("Jinsi = " + xodim[4]);
            //Console.WriteLine("Millati = " + xodim[5]);
            //Console.WriteLine("Telefon raqami = " + xodim[6]);
            //Console.WriteLine("Email = " + xodim[7]);
            //Console.WriteLine("Maoshi = " + xodim[8]);
        }
    }
}