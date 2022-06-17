using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basic
{
    internal class Evenodd
    {
        static void Main(string[] args)
        {
            int n = 5;
            if (n % 2 == 0)
            {
                Console.WriteLine(n+" is even number");     
            }
            else
            {
                Console.WriteLine(n+" is odd number");
            }
        }
    }
}
