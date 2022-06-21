using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class MaximumElementno
    {
        static void Main(string[] args)
        {
            int[] n = { 3, 4, 7, 8, 9, 6 };
            int max = n[0];

            for(int i = 0; i < n.Length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
            }
            Console.WriteLine("Max=" +max);
        }
    }
}
