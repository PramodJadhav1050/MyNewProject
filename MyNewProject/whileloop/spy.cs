using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            int sum = 0, mult = 1;
            while (num != 0)
            {
            int rem = num % 10;
                sum =sum+ rem;
                mult =mult* rem;
                num /= 10;
            }

            if (sum == mult)
            {
                Console.WriteLine("It is a Spy Number.");
            }
            else
            {
                Console.WriteLine("It is not a Spy Number.");
            }
        }
    }
    
}
