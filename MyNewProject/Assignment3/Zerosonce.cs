using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class Zerosonce
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] a1 = new int[a.Length];
            for(int i = 0; i < a1.Length; i++)
            {
                if (a[i] == 0)
                {
                    a1[i] = 0;
                }
                else
                {
                    a1[i] = a[i];
                }
                Console.WriteLine(String.Join(" ", a1)); ;
            }

        }
    }
}
