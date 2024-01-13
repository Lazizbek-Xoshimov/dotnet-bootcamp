using OlineParticipation;
using System;
namespace OnlineParticipation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User { Name = Console.ReadLine() };
            var incpestion = new Incpestion();
            var userCheck = new UserCheck();

            userCheck.UserCheckHendler += incpestion.OnCheckIncpestion;

            userCheck.Check(user);
        }
    }
}