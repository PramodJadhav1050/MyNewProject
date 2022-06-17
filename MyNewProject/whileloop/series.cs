using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class series
    {
        static void Main(string[] args)
        {
            //2,5,10,17,26......
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(i*i+1);
            }
            //2,12,36,80...
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(i * i + (i*i*i)+ " ");
            }

            //0,3,8,15,24.......
            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(i*i-1);
            }
        }
    }
}
