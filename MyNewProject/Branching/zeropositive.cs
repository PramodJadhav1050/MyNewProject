using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Branching
{
    internal class zeropositive
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the number: ");
             int num = int.Parse(Console.ReadLine());

            String pn= (num > 0 ) ? "positive": (num == 0) ? "zero" : "negative";
            Console.WriteLine(pn);  

           
        }
    }
}
