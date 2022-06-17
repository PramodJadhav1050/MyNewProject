using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Inheritance
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
              
            Console.WriteLine("Dog is eating");
        }
    }
    public class Cat : Animal
    {
        public override void eat()
        {
            
            Console.WriteLine("Cat is eating");
        }
    }
            class Demooverride
            {
                public static void Main()
                {
                    Animal A = new Dog();
                    Animal B = new Cat();
                    A.eat();
                    B.eat();
                         
                }
            }
        
    
}