using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Npattern
    {
        static void Main(string[] args)
        {
            int[,] p = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 7, 6, 7, 8 }, { 1, 2, 3, 0 } };
            for (int i = 0; i <= p.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= p.GetUpperBound(1); j++)
                {
                    if (j == 0 || (j == p.GetUpperBound(1)) || j == i)
                    {
                        Console.Write(p[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    
}
