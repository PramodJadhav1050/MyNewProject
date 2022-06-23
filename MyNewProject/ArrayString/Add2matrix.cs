using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Add2matrix
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] b = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] c = new int[3, 3];

            int sum = 0;
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    sum = sum + c[i, j];

                }
            }
           
            Console.WriteLine("sum" + sum);


        }

    }
}
