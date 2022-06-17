using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            /* int i, j, m, k = 4;
             for(i=1;i<=4;i++)
             {
                 for(j=1;j<=k;j++)
                 {
                     Console.Write(" ");
                 }
                 for(m=1;m<=i;m++)
                 {
                     Console.Write(i);
                     Console.Write(" ");
                 }
                 Console.WriteLine("");
                 k = k - 1;
             }*/


            /* for(int i=0;i<=5-1;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<=5-1-i;k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine( );
            }*/

            for (int i = 5; i>=1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            

        }

    }
}
