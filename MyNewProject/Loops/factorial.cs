using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class factorial
    {
        static void Main(string[] args)
        {

            int fact = 1;
            Console.WriteLine("Enter  Number: ");
            int number = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
    }
}
