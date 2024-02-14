using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    // 1) Delegate e'lon qilindi.
    public delegate void ButtonDelegate();
    public class Button
    {
        // 2) Event e'lon qilindi.
        public event ButtonDelegate Click;

        // 3) Button bosilganida nima bo'lishi
        public void Simulation()
        {
            // 4) Button clicked.
            if(Click != null)
            {
                Click();
            }
        }
    }
}
