using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class numberpattern
    {
        static void Main(string[] args)
        {
            /*for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine( );
            }
            Console.WriteLine("////// ");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >=1; j--)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ///////////");*/

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////// ");

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////// ");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////// ");



            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////// ");


            int p = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(p);
                    p++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }

                }

                Console.WriteLine(" ");
            }
            Console.WriteLine("/////////////////");


            int c = 64;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write((char)(c + j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine("");
            }
            








        }
        
    }
}









    
    

