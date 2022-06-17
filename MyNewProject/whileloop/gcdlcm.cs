using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class gcdlcm
    {
        static void Main(string[] args)
        {
            int numerator, denominator, remainder,gcd,lcm;
            Console.WriteLine("enter the value num1:");
           int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value num2:");
            int num2=int.Parse(Console.ReadLine());
            if(num1>num2)
            {
                numerator = num1;
                denominator = num2;

            }
            else
            {
                numerator = num2;
                denominator = num1;
            }
            remainder = numerator % denominator;
            while(remainder !=0)
            {
                numerator = denominator;
                denominator = remainder;
                remainder = numerator % denominator;
            }
            gcd = denominator;
            lcm = num1 * num2 / gcd;

            Console.WriteLine("Gcd of num1 and num2:" +gcd);
            Console.WriteLine("Lcm of num1 and num2:" +lcm);

        }
    }
}
