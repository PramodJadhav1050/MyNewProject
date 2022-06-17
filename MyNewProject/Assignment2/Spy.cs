using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Spy
    {
        static void Main(string[] args)
        {
            int num = 123;
            int sum = 0, mult = 1;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                mult = mult * rem;
                num /= 10;
            }

            if (sum == mult)
            {
                Console.WriteLine( "It is a Spy Number.");
            }
            else
            {
                Console.WriteLine("It is not a Spy Number.");
            }
        }
    }
}
