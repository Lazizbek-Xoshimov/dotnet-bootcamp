using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public class InstantMessageService
    {
        public void OnVideoEncodedForMessage(object source, VideoEventArgs args)
        {
            Console.WriteLine("InstantMessageService: Sending a message... " + args.Video.Title);
        }
    }
}
