using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap OOP Practice");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Circle circle = new Circle();
                        Console.Write("Enter radius:");
                        circle.Radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(circle.ToString());
                        Console.WriteLine($"Perimeter: {circle.Perimeter}");
                        Console.WriteLine($"Area: {circle.Area}");
                        break;

                    case 2:
                        ResizableCircle cir = new ResizableCircle();
                        Console.Write("Enter radius:");
                        cir.Radius = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter percent(%):");
                        cir.Resize(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine($"Radius: {cir.Radius}");
                        Console.WriteLine($"Perimeter: {cir.Perimeter}");
                        Console.WriteLine($"Area: {cir.Area}");
                        break;
                }
            }
        }
    }
}
