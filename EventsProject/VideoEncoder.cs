using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //public delegate void VideoEncoderHandler(object source, VideoEventArgs args);

        //public event VideoEncoderHandler VideoEncoded;

        //public event EventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding a video... ");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
    }
}
