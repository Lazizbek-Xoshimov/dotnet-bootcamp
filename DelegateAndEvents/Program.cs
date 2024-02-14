using DelegateAndEvents;

namespace DelegatesAndEvents
{
    public class Program
    {
        public static void ButtonClick()
        {
            Console.WriteLine("Button is pressed. ");
        }
        public static void Main(string[] args) 
        {
            //Button button = new Button();
            //button.Click += ButtonClick;

            //button.Simulation();

            //button.Click -= ButtonClick;
            //Console.ReadLine();

            (int, string) tuple = (23, "John");
            Console.WriteLine($"{tuple.Item2} is {tuple.Item1} years old. ");
        } 
    }
}