using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Colsum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int sum = 0;
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[j, i] + " ");


                }
                Console.WriteLine("sum=" + sum);
            }
        }
    }
}
