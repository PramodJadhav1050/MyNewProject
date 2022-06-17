using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class sumeven1to10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i += 2)
            {

                sum =sum+i;
            }
            Console.WriteLine("Sum of all even number between 1 to 10=" + sum);
        }
    }
    
}
