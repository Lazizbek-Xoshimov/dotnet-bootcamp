using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoProject
{
    public class PhotoFilters
    {
        public void ApplyBringthness(Photo photo)
        {
            Console.WriteLine("Apply Bringthness. ");
        }
        public void ApplyContrast(Photo photo) 
        {
            Console.WriteLine("Apply Contrast. ");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply Resize. ");
        }
    }
}
