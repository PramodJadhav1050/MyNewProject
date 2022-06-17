using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class sumofdigit
    {
        static void Main(string[] args)
        {
            int n = 246;
            int a = n;
            int sum = 0;
            while (n != 0)
            {
                int r = n % 10;
                sum=sum+r;
                n = n / 10;
            }
            Console.WriteLine($"number is = {a} & sum of digit = {sum}");

        }
    }
}
