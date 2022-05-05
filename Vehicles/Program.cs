using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Walter", "ALX300", "White",100 ,34 );

            Console.WriteLine(bus.Info());
        }
    }
}
