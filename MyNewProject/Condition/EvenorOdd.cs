using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class EvenorOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num+" is the number is even");
            }
            else
            {
                Console.WriteLine(num+" is the number is odd");
            }
        }
    }
}
