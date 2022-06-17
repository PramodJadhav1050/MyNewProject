using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class sumoddno1to20
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Print odd numbers between 1 to 20");
            int num = 0;
            for (int i = 1; i <=20; i+=2)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                    num++;
                }

            }
            Console.WriteLine("count of odd number is =" +num);
        }
    }
}
