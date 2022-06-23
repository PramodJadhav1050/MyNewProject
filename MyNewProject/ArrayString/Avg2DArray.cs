using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Avg2DArray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int sum = 0;
                int avg = 0;
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    sum = sum + a[i, j];
                    avg = sum / a.GetLength(0);

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(a.GetLength(0));
                Console.Write("sum=" + sum);
                Console.Write("avg=" + avg);
                Console.WriteLine();

            }
        }
        
    }
}
