using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class AreaMethod
    {
            public void Area(double radius)
            {
                double pi = 3.14;
                double result = pi * radius * radius;
                Console.WriteLine("Area of a circle = " + result);

            }

            public void Area(int Side)
            {

                int result = Side * Side;
                Console.WriteLine("Area of a square = " + result);
            }
            public void Area(int length, int breath)
            {
                int result = length * breath;
                Console.WriteLine("area of reactangle= " + result);
            }
            public void Area(double basee, double height)
            {
                double result = (basee * height) / 2;
                Console.WriteLine("area of triangle =  " + result);
            }
            static void Main(string[] args)
            {
                AreaMethod  A = new AreaMethod();
                A.Area(1.5);
                A.Area(5);
                A.Area(6, 7);
                A.Area(2.5, 6);
            }
        
    }
}
