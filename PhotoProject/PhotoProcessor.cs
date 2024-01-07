using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoProject
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path,  PhotoFilterHandler handler)
        {
            var photo = Photo.Load(path);
            handler(photo);
        }
    }
}
