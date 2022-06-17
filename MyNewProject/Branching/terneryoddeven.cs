using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Branching
{
    internal class terneryoddeven
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number :");
             int num = int.Parse(Console.ReadLine());

            String str = (num % 2 == 0) ? "even" : "odd";
            Console.Write(str);

          
        }

    }
}   

