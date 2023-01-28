using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Student
    {
        public Student()
        {
            //Default Constructor
        }
        public Student(string name, int rollno, float cgpa, float Emarks, float Fmarks, string homeTown, bool isHostalide)
        {
            this.name = name;
            this.rollno = rollno;
            this.cgpa = cgpa;
            this.Emarks = Emarks;
            this.homeTown = homeTown;
            this.isHostalide = isHostalide;
            this.isAvailingScholarship = false;
        }
        public string name;
        public int rollno;
        public float cgpa;
        public float Emarks;
        public float Fmarks;
        public string homeTown;
        public bool isHostalide;
        public bool isAvailingScholarship;


        public float CalculateMerit()
        {
            float aggr;
            aggr = (((Fmarks * 60) / 1100) + ((Emarks * 40) / 400)) * 100;
            return aggr;
        }
        public bool isEligibleforScholarship(float meritPercentage)
        {
            float merit = CalculateMerit();
            isAvailingScholarship = false;
            if (meritPercentage < merit && isHostalide)
            {
                isAvailingScholarship = true;
            }
            return isAvailingScholarship;
        }
    }
}
