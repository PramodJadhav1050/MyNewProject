using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class SepZero
    {
        static void SeprateZeros(int[] arr, int n)
        {

            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    arr[count++] = arr[i];

            while (count < n)
                arr[count++] = 0;
        }


        public static void Main()
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3};
            int n = arr.Length;
            SeprateZeros(arr, n);
            Console.WriteLine("Sperate all zeros: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}