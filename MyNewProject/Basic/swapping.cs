using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Basic
{
    internal class swapping
    {
        public static void Main(string[] args)
        {
            int a = 8, b = 10;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After sawpping a=" +a+"b=" +b);
        }
    }
}
