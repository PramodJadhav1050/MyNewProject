using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    class Test
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void main(String[] args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }
    }



}

