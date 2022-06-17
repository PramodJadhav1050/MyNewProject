using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject.OOPS
{
    
    class Studentget
    {
        private int sid;
        private string sname;
        private float spercentage;
        private bool splace;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        private float Spercentage
        {
            get { return spercentage; }
            set { spercentage = value; }
        }
        public bool Splace
        {
            get { return splace; }
            set { splace = value; }
        }
        static void Main(string[] args)
        {
            Studentget s= new Studentget();
            s.sid = 201;
            s.Sname = "Pramod";
            s.Spercentage = 84;
            s.Splace = true;
            Console.WriteLine(s.sid+" "+s.Sname+" "+s.Spercentage+" "+s.Splace);
        }
    }
}
