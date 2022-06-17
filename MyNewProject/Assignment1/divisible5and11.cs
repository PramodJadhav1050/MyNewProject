using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class divisible5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine(num + "is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine(num + "is not divisible by 5 and 11");

            }
        }
    }
}
