using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    
    
        class CEngine
        {
            string type;
            public string Type
            {
                get { return type; }
                set { type = value;}
            }

        }
        class Carf
        {
            int modelno;
            string name;
            int price;
            CEngine eng;
            public int Modelno
            {
                get { return modelno; }
                set { modelno = value; }

            }
            public string Name
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public  CEngine Eng
            {
                get { return eng; }
                set { eng = value; }

            }
            static void Main(string[] args)
            {
                Carf c = new Carf();
                c.Modelno = 655;
                c.Name = "Nano";
                c.Price = 150000;
                c.Eng = new CEngine();

                c.Eng.Type = "ic engine";
                Console.WriteLine(c.Modelno + " " + c.Name + "  " + c.Price + "  " + c.Eng.Type);
            }
        }


    
}

