using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sq = n * n;

            Console.WriteLine("square of number" + sq);
            int sum = 0;
            int count = 0;
            while (n > 0)
            {
                int r = sq % 10;
                count++;

                sq = sq / 10;

            }
            Console.WriteLine("sum of digit of square" + sum);

            if (sum == n)
            {
                Console.WriteLine("this is Kaprakar number");

            }
            else
            {
                Console.WriteLine("this is not kaprakar");
            }
            Console.ReadLine();
        }


    }
    
}
