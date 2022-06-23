using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class PatternN
    {
        static void Main(string[] args)
        {
            string[,] a = new string[10, 10];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] = "*";
                }

            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == a.GetLength(1) - 1)
                    {
                        Console.Write(a[i, j]);
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

