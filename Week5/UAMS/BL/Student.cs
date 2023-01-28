using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Student
    {
        public Student()
        {

        }
        public Student(string name, int age, float Fmarks, float Emarks, List<DegreeProgram> Preferences)
        {
            this.name = name;
            this.age = age;
            this.Fmarks = Fmarks;
            this.Emarks = Emarks;
            this.merit = CalculateMerit();
            this.Preferences = Preferences;
            this.RegisteredDegree = null;
        }
        public string name;
        public int age;
        public float Fmarks;
        public float Emarks;
        public float merit;
        public List<DegreeProgram> Preferences;
        public List<Subjects> RegisteredSubjects = new List<Subjects>();
        public DegreeProgram RegisteredDegree;

        public static List<Student> students = new List<Student>();

        public static void AddStudentInList(Student stu)
        {

            students.Add(stu);
        }
        public static void SortStudentList()
        {
            //students = students.OrderByDescending(o => o.merit).ToList();
            students.Sort((x, y) => x.merit.CompareTo(y.merit));
            students.Reverse();
        }
        public static int isStudentAvailable(string name)
        {
            int idx = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (name == students[i].name)
                {
                    if (students[i].RegisteredStudent())
                    {
                        idx = i;
                    }
                    else
                    {
                        idx = -1;
                    }
                    break;
                }
            }
            return idx;
        }
        public float CalculateMerit()
        {

            float aggr;
            aggr = (Fmarks / 1100 * 60) + (Emarks / 400 * 40);
            return aggr;
        }

        public bool RegisteredStudent()
        {
            if (this.RegisteredDegree != null)
            {
                return true;
            }
            return false;
        }
        public bool RegisteredStudentOfDegree(string degreeName)
        {
            if (this.RegisteredDegree.title == degreeName)
            {
                return true;
            }
            return false;
        }
        public bool IsApplicable()
        {
            for (int i = 0; i < this.Preferences.Count; i++)
            {
                DegreeProgram temp = this.Preferences[i];
                if (temp.seats != 0)
                {
                    temp.seats--;
                    this.RegisteredDegree = temp;
                    return true;
                }
            }
            this.RegisteredDegree = null;
            return false;
        }
        public int TotalCH(Subjects sub)
        {
            int totalCH = 0;
            foreach (var s in RegisteredDegree.OfferedSubjects)
            {
                totalCH += s.CH;
            }
            totalCH += sub.CH;
            return totalCH;
        }
        public float GenerateFee()
        {
            float fee = -1;
            if (this.RegisteredDegree != null)
            {
                fee = 0;
                if (this.RegisteredSubjects.Count != 0)
                {
                    for (int i = 0; i < this.RegisteredSubjects.Count; i++)
                    {
                        fee += this.RegisteredSubjects[i].fee;
                    }
                }

            }
            return fee;
        }
    }
}