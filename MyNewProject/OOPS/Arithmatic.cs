using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class Arithmatic
    {
        void Calculate()
        {
            int x = 3;
            int y = 7;
            Console.WriteLine("addition= " +( x + y));
        }
        public void Calculate(int x, int y)
        {
            Console.WriteLine("subtract= " + (x - y));
        }
        public void Calculate(double x, double y)
        {
            Console.WriteLine("multiplication= " + (x * y));
        }
        public void Calculate(float x, float y)
        {
            Console.WriteLine("divide= " + (x / y));
        }
        static void Main(string[] args)
        {
            Arithmatic A = new Arithmatic();
            A.Calculate(3, 7);
            A.Calculate(5, 7);
            A.Calculate(3.5, 2);
            A.Calculate(55, 5);

        }
    }
}
    

