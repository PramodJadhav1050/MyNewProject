using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Oddposition
    {
        static void Main(string[] args)
        {
            int[] s = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("length=" + s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
