using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class AlternateElement
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i, j, temp;
            Console.WriteLine("Enter the element of an array");
            for(i = 0; i <arr.Length; i++)
            {
                arr[i] = i;
                
            }
            for(i=0;i<arr.Length;i+=2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
