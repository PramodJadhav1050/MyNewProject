using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Branching
{
    internal class absolute
    {
        static void Main(string[] args)
        {
         
            Console.Write("Enter a number");
            int num = int.Parse(Console.ReadLine());

           int  n = num >= 0 ? num : (-(num));
            Console.WriteLine(n);
            
        }
    }
}
