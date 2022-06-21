using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class MinumumChar
    {
        static void Main(string[] args)
        {
            Char[] c = { 'a', 'b', 'b', 'c', 'b' };
            Char min=c[0];
            int x = 0;
            for(int i = 0; i < c.Length; i++)
            {
                x = c[i];
                Console.WriteLine(c[i]+" "+x);
                if(c[i] < min)
                {
                    min = c[i];
                }       
            }
            Console.WriteLine("///////////////////////");
            Console.WriteLine("Min=" + min);
        }
    }
}
