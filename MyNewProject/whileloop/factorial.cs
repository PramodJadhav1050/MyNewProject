using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            
           
            
            int fact =1;
            int sum =0;
            for (int  i=1;i<=5;i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine("Factorial of 1 to 5 is: " + sum);
        }
    }
}
