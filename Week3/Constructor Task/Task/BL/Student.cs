using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BL
{
    class Student
    {
        public Student()
        {
            name = "Ali";
            matric = 10F;
            fsc = 10F;
            ecat = 10F;
            aggr = 0F;
        }
        public Student(Student s)
        {
            name = s.name;
            matric = s.matric;
            fsc = s.fsc;
            ecat = s.ecat;
            aggr = s.aggr;
        }
        public Student(string n, float m, float f, float e)
        {
            name = n;
            matric = m;
            fsc = f;
            ecat = e;
            aggr = 0F;
        }
        public string name;
        public float matric;
        public float fsc;
        public float ecat;
        public float aggr;
    }
}
