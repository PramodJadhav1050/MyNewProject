using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class binarytodecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter binary number");
            int Num=int.Parse(Console.ReadLine());


            int sum = 0;
            int p = 0;


            while(Num>0)
            {
                int r = Num % 10;
                int power = (int)(Math.Pow(2, p));
                sum=sum + (power*r);
                Num=Num/10;
                p++;
                
            }
              Console.WriteLine(sum);

        }
    }
}
