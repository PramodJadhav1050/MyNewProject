using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class divisible5and10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divided by 5 and 10");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 10 == 0)
                {
                    Console.Write(i + " ");
                }              
            }
            
        }
    }
}
