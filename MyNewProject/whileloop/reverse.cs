using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
