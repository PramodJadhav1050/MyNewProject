using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class pattern
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i<=4; i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.WriteLine(" ");
                }
                for(int j=1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            */


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            int pat = 1;
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= pat; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                pat++;
            }


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == j || i == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == ((5 / 2) + 1))
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("*");
                    }

                }
                else
                {
                    for (int j = 1; j <= 5 / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int patt = 1;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 4)
                    {
                        Console.Write("*");
                    }
                    else if (j == patt)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                patt++;
                Console.WriteLine();
            }

        }
    }

}