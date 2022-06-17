using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Loops
{
    internal class fibo
    {
        static void Main(string[] args)
        {
            int firstNumber=0 , SecondNumber=1, nextNumber;
            Console.Write("fibbonaci series");
            Console.Write(firstNumber + " " + SecondNumber + " ");
            for (int i = 2; i <10; i++)
            {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
            }
                   


        }
    }
}
