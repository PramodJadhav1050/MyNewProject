using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    
 
        class SubEngine
        {
            string cleanupDate;
            public SubEngine(string CleanupDate)
            {
                this.cleanupDate = CleanupDate;
            }
            public void Show()
            {
                Console.WriteLine(cleanupDate);
            }
        }
         class Engine
        {
            string type;
            SubEngine sub;
            public Engine(string type, SubEngine sub)
            {
                this.type = type;
                this.sub = sub;

            }
            public void ShowEngine()
            {
                Console.WriteLine(type);
                sub.Show();
            }
        }
        class cars
        {
            int model;
            string name;
            int price;
            Engine e;
            cars(int model, string name, int price, Engine e)
            {
                this.model = model;
                this.name = name;
                this.price = price;
                this.e = e;
            }
            public void showCar()
            {
                Console.WriteLine(model + " " + name + " " + price);
                e.ShowEngine();
            }
            static void Main(string[] args)
            {
               cars c = new cars(123, "Audi", 950000, new Engine("Petrol", new SubEngine("5/5/2022")));

                c.showCar();
            }
        }


    
}

