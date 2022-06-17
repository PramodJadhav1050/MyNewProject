using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class odd15to30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd Numbers=");
            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
