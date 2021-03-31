using System;

namespace Vehicles
{
    class Program
    {
        static void Main()
        {
            var myCar = new Car();
            myCar.Drive();

            var mySportsCar = new Sportscar();
            mySportsCar.Drive();

            var myVan = new Van();
            myVan.Drive();

            var myMiniVan = new Minivan();
            myMiniVan.Drive();

            var myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();
        }
    }
}
