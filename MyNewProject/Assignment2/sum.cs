using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class sum
    {
        static void Main(string[] args)
        {
            int num, i, j, fact, sum = 0;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = 1;
                if(i !=num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                for (j = 1; j <= i; j++)
                    fact = fact * j;
                sum = sum + fact;

            }
            Console.WriteLine("sum of .........." +sum);
        }
    }
}
