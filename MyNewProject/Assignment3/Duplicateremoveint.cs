using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    internal class Duplicateremoveint
    {
        static void Main(string[] args)
        {
            int i = 0 ,j = 1;
            int[] arr = { 4, 3, 2, 4, 9, 2 };
            for (  i = 0; i < arr.Length; i++)
            {
                for ( j = 1; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr[j] == arr[i])
                        break;
                }
                if (arr.Length == j)
                {
                    Console.Write(arr[i] + "  ");
                }
            }
        }
    }
}
