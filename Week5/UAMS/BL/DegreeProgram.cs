using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public DegreeProgram()
        {

        }
        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.OfferedSubjects = new List<Subjects>();
        }
        public string title;
        public string duration;
        public int seats;
        public List<Subjects> OfferedSubjects;

        public static List<DegreeProgram> OfferedDegree = new List<DegreeProgram>();
        public void AddOfferedSubjectInList(List<Subjects> OfferedSubjects)
        {
            this.OfferedSubjects = OfferedSubjects;
        }
        public static void AddDegreeInList(DegreeProgram degree)
        {
            OfferedDegree.Add(degree);
        }
        public bool IsSubjectExists(Subjects subject)
        {
            foreach (var sub in OfferedSubjects)
            {
                if (sub.code == subject.code)
                {
                    return true;
                }
            }
            return false;
        }
        public int TotalCH(Subjects sub)
        {
            int totalCH = 0;
            foreach (var s in OfferedSubjects)
            {
                totalCH += s.CH;
            }
            totalCH += sub.CH;
            return totalCH;
        }


        public static int IsDegreeExists(string degreeName)
        {
            //foreach (var deg in OfferedDegree)
            for (int i = 0; i < OfferedDegree.Count; i++)
            {
                if (OfferedDegree[i].title == degreeName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
