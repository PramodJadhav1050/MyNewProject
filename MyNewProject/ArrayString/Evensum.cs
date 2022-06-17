using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Evensum
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("sum of even element  = " + sum);
        }
    }

}

