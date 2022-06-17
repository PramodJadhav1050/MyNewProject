using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class Greatestno
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
          
            Console.WriteLine("Enter the  1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1+ "is the greatest between three");
                }
                else
                {
                    Console.WriteLine(num3+ "is the greatest between three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2+ "is the greatest between three");
            }
            else 
            {
                Console.WriteLine(num3+ "is the greatest between three");
            }
            
        }
    }
}
    

