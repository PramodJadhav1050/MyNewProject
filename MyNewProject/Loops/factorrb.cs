using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class factorrb
    {
        static void Main(string[] args)
        {
            for(int i =1;i<=50; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("red blue");
                }
                else if(i%3==0)
                { 
                    Console.WriteLine("red"); 
                
                }
                else if(i %5==0)
                {
                    Console.WriteLine("blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
