using System;

namespace Album
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum obj = new PhotoAlbum();
            PhotoAlbum obj2 = new PhotoAlbum(24);
            BigPhotoAlbum obj3 = new BigPhotoAlbum();

            Console.WriteLine($"Number of pages in Album using default constructor : {obj.getNumberOfPages()}");
            Console.WriteLine($"Number of pages in Album using parameterized constructor : {obj2.getNumberOfPages()}");
            Console.WriteLine($"Number of pages in Big Photo Album : {obj3.getNumberOfPages()}");
        }
    }
}
