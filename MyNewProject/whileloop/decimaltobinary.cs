using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class decimaltobinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int p = 1;
            while (num > 0)
            {
                int r = num % 2;
                sum = sum + (r * p);
                p = p * 10;
                num = num / 2;
            }
            Console.WriteLine(sum);

        }
    }
}
