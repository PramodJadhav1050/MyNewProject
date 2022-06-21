using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.Assignment3
{

    class Nib
    {
        string materialtype;
        int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }

        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public void ShowNib()
        {
            Console.WriteLine(materialtype+" "+width);
        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib nib;
        public string Inkcolor
        {
            get { return inkcolor;}
            set { inkcolor = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public void ShowRefill()
        {
            Nib.ShowNib();
            Console.WriteLine(inkcolor+ " "+Length);
        }
        
    }
    internal class Pengetset
    {
        
        string brand;
        int caplength;
        Refill refill;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public Refill Refill
        {
            get { return refill; }
            set { refill = value; }
        }
        public void ShowPen()
        {
            Refill.ShowRefill();
            Console.WriteLine(Brand+" "+Caplength);
        }
        static void Main(string[] args)
        {
            Pengetset p = new Pengetset();
            p.Brand = "Champ";
            p.Caplength = 10;
            p.Refill.Inkcolor = "Blue";
            p.Refill.Length = 10;
            p.Refill.Nib.Materialtype = "xx";
            p.Refill.Nib.Width = 2;
            p.ShowPen();
        }
    }
}
