using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlineParticipation
{
    //public class UserCheckArgs: EventArgs
    //{
    //    public User User { get; set; }
    //}
    public class UserCheck
    {
        public delegate void UserCheckHendlerDelegate(User user);
        public event UserCheckHendlerDelegate UserCheckHendler;

        public virtual void OnUserCheck(User user)
        {
            if(UserCheckHendler != null)
            {
                //UserCheckHendler(this, new UserCheckArgs() { User = user});
                UserCheckHendler(user);
            }
        }

        public void Check(User user)
        {
            Console.Write($"{user.Name} ");
            OnUserCheck(user);
        }
    }
}
