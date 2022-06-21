using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.ArrayString
{
     class ReverseArray
    {
        public int[] RreverseArray(int[] reverse)
        {
            
            int j = reverse.Length - 1;
            for(int i = 0; i < reverse.Length/2; i++)
            {
                int temp=reverse[i];
                reverse[i] = reverse[j];
                reverse[j] = temp;
                j--;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 5, 1, 2 };
            ReverseArray m = new ReverseArray();
            int[] b =m.RreverseArray(a);
            Console.WriteLine(String.Join(" ",b));
        }
    }
}
