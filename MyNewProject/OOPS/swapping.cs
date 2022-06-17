using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    internal class swapping
    {
        public void swap(ref int  x ,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            swapping swapping = new swapping();
            Console.WriteLine("Enter the 1st number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2=int.Parse(Console.ReadLine());
            swapping.swap(ref num1,ref num2);
            Console.WriteLine("..............................");
            Console.WriteLine(num1 + "  " + num2);
        }
    }
}
