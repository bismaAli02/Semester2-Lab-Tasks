using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class Student
    {
        // Constructor
        public Student()
        {

        }
        public Student(string name, int age, float Fmarks, float Emarks)
        {
            this.name = name;
            this.age = age;
            this.Fmarks = Fmarks;
            this.Emarks = Emarks;
            gotAdmission = false;
            Prefernces = new List<DegreeProgram>();
            RegisterSubjects = new List<Subject>();
        }

        // Member Variables
        public string name;
        public int age;
        public float Fmarks;
        public float Emarks;
        public List<DegreeProgram> Prefernces;
        public bool gotAdmission;
        public List<Subject> RegisterSubjects;
        public float merit;

        public void AddPreference(DegreeProgram d)
        {
            Prefernces.Add(d);
        }

    }
}
