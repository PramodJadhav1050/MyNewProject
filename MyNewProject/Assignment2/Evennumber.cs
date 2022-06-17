using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Evennumber
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=50)
            {
                i++;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i+" "+(i*i));
                }
            }
        }
    }
}
