using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class Areaofequilateral
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            float side=float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of  equilateral triangle is =" +area);
        }
    }
}
