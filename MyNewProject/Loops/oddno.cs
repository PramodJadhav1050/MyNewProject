using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class oddno
    {
        static void Main(string[] args)
        {
            for (int i = 500; i <= 600; i++)
            {
                if (i % 2 == 1)
                { 
                    Console.Write(i+ " ");
                }
            }
        }
    }
}
