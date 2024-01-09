using EventsProject;

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() {Title = "Birinchi video." };
            var videoEncoder = new VideoEncoder();
            var mailService = new EmailService();
            var messageService = new InstantMessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncodedForEmail;
            videoEncoder.VideoEncoded += messageService.OnVideoEncodedForMessage;

            videoEncoder.Encode(video);
        }
    }
}