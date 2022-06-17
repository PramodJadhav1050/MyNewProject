using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Condition
{
    internal class perstudent
    {
        static void Main(string[] args)
        {
            float average, percentage, total = 500f;
            float maths, science, english, physics, chemistry;

            Console.WriteLine("Enter Marks for Maths");
            maths = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Marks for Science");
            science = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Marks for English");
            english = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Marks for Physics");
            physics = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Marks for Chemistry");
            chemistry = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Validating Marks....");
            total = (maths + science + english + physics + chemistry);
            
            Console.WriteLine( "Total score is:" +total);
            average = total/5;
            
            Console.WriteLine("Average score is :" +average);
            percentage = average % 100;
            
            Console.WriteLine("Percentage obtained by student is:" +percentage);
            
        }
    }
} 
      
    
