using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment1
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("sum is" + c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("sub is" + c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("multi is" + c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Dividation is" + c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
