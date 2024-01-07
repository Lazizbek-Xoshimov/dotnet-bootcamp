using PhotoProject;

namespace DelegateMasala2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBringthness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            processor.Process("photo.jpg", filterHandler);
        }
    }
}