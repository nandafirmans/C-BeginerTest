using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photoObject); 

        public void Process(string path, PhotoFilterHandler DelegatedFilter)
        {
            var photo = Photo.Load(path);

            DelegatedFilter(photo);

            photo.Save();
        }
    }
}
