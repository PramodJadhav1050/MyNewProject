using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Static
    {
        static void Display()
        {
            Console.WriteLine("static overloading");
        }
        static void Display(int x)
        {
            Console.WriteLine("x=  " + x);
        }
        static void Display(string y)
        {
            Console.WriteLine(y);
        }
        static void Display(int x, int y)
        {
            Console.WriteLine("Addition=  " + (x + y));
        }


        static void Main(string[] args)
        {
            Static.Display();
            Static.Display(87, 87);
            Static.Display("Pramod");
            Static.Display(87);

        }
    }
}
