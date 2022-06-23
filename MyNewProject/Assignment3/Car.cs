using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{
    class SubEngine
    {
        string subenginetype;
        public  SubEngine (string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void ShowSub()
        {
            Console.WriteLine(subenginetype);
        }
    }
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        
        public Engine(int engineid, string lastenginecleandate)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            
        }
        public void ShowEngine()
        {
            Console.WriteLine(engineid+ " "+lastenginecleandate);
            
        }
    }
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }   
        public void ShowGear()
        {
            Console.WriteLine(type+ " ");
          
        }
    }
    internal class Car

    {
        int carid;
        string carcolor;
        Engine engine;
        SubEngine sub;
        Gear gear;
        public Car(int carid, string carcolor, Engine engine, SubEngine sub, Gear gear)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.engine = engine;
            this.sub = sub;
            this.gear = gear;
        }
        public void Showcar()
        {
            Console.WriteLine(carid+" "+carcolor);
            engine.ShowEngine();
            gear.ShowGear();
            sub.ShowSub();

        }
        static void Main(string[] args)
        {
            Car c = new Car(123, "white" , new Engine (111, "06/30/22"), new SubEngine( "Petrol"), new Gear("Auto"));
            c.Showcar();
           

        }
    }
}
