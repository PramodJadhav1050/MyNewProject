using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
    internal class MergeArray
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[10];

            
            Console.WriteLine("Enter elements of Array 1st : ");
            for (i = 0; i < 5; i++)
            {
               // Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

        
            Console.WriteLine("Enter elements of Array 2nd : ");
            for (i = 0; i < 5; i++)
            {
                
                arr2[i] = int.Parse(Console.ReadLine());
            }

            
            for (i = 0, j = 0; i < 5; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                arr3[j++] = arr2[i];
            }


             Console.WriteLine("Elements of Array 3rd : ");
             for (i = 0; i < 10; i++)
             {
                 Console.WriteLine( arr3[i]);

             }

            Console.WriteLine();
        }
    }
}

