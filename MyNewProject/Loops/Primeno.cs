using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class Primeno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {

                    isprime = false;
                    break;
                }
            }
                if (isprime)
                {
                    Console.WriteLine(n+ "is prime");
                }
                else
                {
                    Console.WriteLine(n+ "is not prime");
                }


            

        }
    }
}
