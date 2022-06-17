using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Series
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=10)
            {
                Console.WriteLine((i*i)+(i*i*i));
                i++;
            }
        }
    }
}
