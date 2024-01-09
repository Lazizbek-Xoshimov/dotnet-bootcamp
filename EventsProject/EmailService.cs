using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public class EmailService
    {
        public void OnVideoEncodedForEmail(object source, VideoEventArgs args)
        {
            Console.WriteLine("Email Service: Sending an email... " + args.Video.Title);
        }
    }
}
