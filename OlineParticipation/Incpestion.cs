using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlineParticipation
{
    public class Incpestion
    {
        public string[] names = { "Lazizbek", "Nurmurod", "Zohidbek" };
        public void OnCheckIncpestion(User user)
        {
            bool Lamp = false;
            foreach (var name in names)
            {
                if(user.Name == name)
                {
                    Console.WriteLine("kirishingiz taqiqlangan! ");
                    Lamp = false;
                    break;
                }
                else Lamp = true;
            }
            if(Lamp) 
                Console.WriteLine("xush kelibsiz! ");
        }
    }
}
