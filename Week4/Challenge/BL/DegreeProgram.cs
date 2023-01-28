using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class DegreeProgram
    {
        public DegreeProgram()
        {

        }
        public DegreeProgram(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }
        public string title;
        public int duration;
        public int seats;
        public float Hmerit;
        public List<Subject> offeredSubjects = new List<Subject>();


    }
}
