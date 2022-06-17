using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class Areaofequilateraltriangle
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Length of Side");
            float side = float.Parse(Console.ReadLine());
            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is" +area);
        }
    }
}
