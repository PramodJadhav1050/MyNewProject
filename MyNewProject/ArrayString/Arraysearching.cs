using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class Arraysearching
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 7, 9 };
            Console.WriteLine("Element for search");
            int num=int.Parse(Console.ReadLine());
            bool isPresent = false;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    isPresent = true;
                    break;
                }
            }
            if(isPresent== true)
            {
                Console.WriteLine("Element is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }
    }
}
