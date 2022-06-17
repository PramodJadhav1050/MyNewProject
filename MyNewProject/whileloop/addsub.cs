using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.whileloop
{
    internal class addsub
    {
        static void Main(string[] args)
        {

            char ch;
            do
            {
                
                Console.Write("Enter A:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1.Add");
                Console.WriteLine("2.Substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue.............");
                  ch = Console.ReadLine()[0];

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
