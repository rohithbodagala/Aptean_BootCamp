using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    public class BigPhotoAlbum
    {
        int numberOfPages;

        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }

        public int getNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
