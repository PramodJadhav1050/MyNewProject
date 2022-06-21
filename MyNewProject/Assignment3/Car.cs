using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    class subengine
    {
        string subenginetype;
        public  subengine (string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void showsub()
        {
            Console.WriteLine(subenginetype);
        }
    }
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        subengine sub;
        public Engine(int engineid, string lastenginecleandate, subengine sub)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            
        }
        public void ShowEngine()
        {
            Console.WriteLine(engineid+ " "+lastenginecleandate);
            sub.showsub();
        }
    }
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }   
        public void Showgear()
        {
            Console.WriteLine(type);
          
        }
    }
    internal class Car

    {
        int carid;
        string carcolor;
        string engine;
        string gear;
        public Car(int carid, string carcolor, string engine, string gear)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.engine = engine;
            this.gear = gear;
        }
        public void Showcar()
        {
            Console.WriteLine(carid+" "+carcolor);
            Engine.ShowEngine();
            Gear.Showgear();

        }
        static void Main(string[] args)
        {
            Car c = new Car(123, "white", newengine(111, "06/30/22", new subengine("Petrol")), new gear("Auto"));
            c.Showcar();
           

        }
    }
}
