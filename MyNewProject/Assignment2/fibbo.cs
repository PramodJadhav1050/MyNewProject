using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class fibbo
    {
        static void Main(string[] args)
        {
            int a=0,b=1,c=0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i=2;i<20;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
