using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    class AdmissionBranch
    {
        public AdmissionBranch()
        {

        }
        public AdmissionBranch(Student s)
        {
            students.Add(s);
        }
        public List<Student> students = new List<Student>();
        public List<RegisteredStudent> registeredStudents = new List<RegisteredStudent>();

        public void GenerateMeritList()
        {
            students.Sort((x, y) => x.merit.CompareTo(y.merit));
            students.Reverse();
            int idx = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if ((idx = isApplicable(students[i])) != -1)
                {
                    Console.WriteLine("Student name: " + students[i].name + " got Admission in: " + students[i].Prefernces[idx].title);
                }
            }

        }
        public int isApplicable(Student s)
        {
            for (int i = 0; i < s.Prefernces.Count; i++)
            {
                DegreeProgram temp = s.Prefernces[i];
                if (s.merit >= temp.Hmerit && temp.seats != 0)
                {
                    s.gotAdmission = true;
                    RegisteredStudent r = new RegisteredStudent();
                    temp.seats--;
                    r.s = s;
                    r.degree = temp;
                    registeredStudents.Add(r);
                    return i;
                }
            }

            return -1;
        }


    }
}
