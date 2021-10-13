using System;

namespace sedova2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координату x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координату y:");
            double y = double.Parse(Console.ReadLine());
            if (y <= -x + 1 && y >= -x && y <= x && y >= x - 1) Console.WriteLine("Точка попадает в область.");
            else Console.WriteLine("Точка не попадает в область");
        }
    }
}
