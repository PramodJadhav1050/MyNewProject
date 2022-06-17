using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class square
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            
            
                int result = num * num;
            
            Console.WriteLine("Square of" + num + "is" + result);



        }
    }
}
