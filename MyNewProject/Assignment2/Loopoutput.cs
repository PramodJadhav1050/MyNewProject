using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment2
{
    internal class Loopoutput
    {
        static void Main(string[] args)
        {
            /*int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b !=3);*/

            /* int i = 1,K = 1;
             while (i++<=5)
             {
                 K *= i;
             }
             Console.WriteLine("k="+K+ "i=" +i);*/


            /* for(int i=5;i>0;i--)
             {
                 int mystryInt = 100;
                 mystryInt = i;
                 Console.WriteLine(mystryInt);
            }*/

            int i = 1;
            while(i<=5)
            {
                int j = 1;
                while (j<=5)
                {
                    if(j==2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }
}
