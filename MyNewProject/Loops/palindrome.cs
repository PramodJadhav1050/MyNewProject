using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enyter the number");
            int num=int.Parse(Console.ReadLine());
            int copy = num;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;
            }
            if(sum == copy)
            {
                Console.WriteLine($"{copy} is palindrome");
            }
            else
            {
                Console.WriteLine($"{copy} is not palindrome");
            }

        }
    }
}
