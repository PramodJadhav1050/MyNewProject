using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((y % 4 == 0))
            {
                Console.WriteLine(y + "is a Leap Year");
            }
            else
            {
                Console.WriteLine(y + "is not a Leap Year");
            }
        }
    }
}
