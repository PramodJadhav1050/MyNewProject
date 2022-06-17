using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            int r;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }
        }
    }
}
