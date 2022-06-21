using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class MinimumElementno
    {
        static void Main(string[] args)
        {
            int[] n = { 3, 4, 7, 8, 9, 6 };
            int min = n[0];

            for (int i = 0; i > n.Length; i--)
            {
                if (n[i] > min)
                {
                    min = n[i];
                }
            }
            Console.WriteLine("Min=" + min);
        }
    }
}
