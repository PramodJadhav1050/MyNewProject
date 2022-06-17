using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class sumodd
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all even number between 1 to " + n + " = " + sum);
        }
    }
}
