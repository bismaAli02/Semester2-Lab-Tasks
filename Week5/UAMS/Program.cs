using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static char Menu()
        {
            char op;
            Console.WriteLine("Press 1 to Add Degree");
            Console.WriteLine("Press 2 to Add Student");
            Console.WriteLine("Press 3 to Generate Merit");
            Console.WriteLine("Press 4 to see registered Students");
            Console.WriteLine("Press 5 to view Students of a specific Degree");
            Console.WriteLine("Press 6 to register subjects for a specific Student");
            Console.WriteLine("Press 7 to Calculate Fee for all registered Students");
            Console.WriteLine("Press 8 to EXIT!");
            op = char.Parse(Console.ReadLine());
            return op;
        }
        static void AddSubject(DegreeProgram degree)
        {
            char op;
            do
            {
                string code, type;
                int CH, fee;

                Console.Write("Enter the Code of Subject: ");
                code = Console.ReadLine();
                Console.Write("Enter the Type of Subject: ");
                type = Console.ReadLine();
                Console.Write("Enter the Credit Hours of Subject: ");
                CH = int.Parse(Console.ReadLine());
                Console.Write("Enter the Fees of Subject: ");
                fee = int.Parse(Console.ReadLine());
                Subjects s = new Subjects(code, CH, type, fee);
                if (degree.TotalCH(s) <= 20)
                {
                    if (!degree.IsSubjectExists(s))
                    {
                        degree.OfferedSubjects.Add(s);
                    }
                    else
                    {
                        Console.WriteLine("You cannot add This subject as this is already Present!!");
                    }
                }
                else
                {
                    Console.WriteLine("You cannot add This subject!!");

                }
                Console.WriteLine("Press E to exit or any other character to add More Subject!");
                op = char.Parse(Console.ReadLine());
            } while (op != 'e' && op != 'E');
        }
        static DegreeProgram AddDegree()
        {
            string title, duration;
            int seats;
            Console.Write("Enter the title of degree: ");
            title = Console.ReadLine();
            Console.Write("Enter the Duration of degree: ");
            duration = Console.ReadLine();
            Console.Write("Enter the Total Seats of degree: ");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram degree = new DegreeProgram(title, duration, seats);

            AddSubject(degree);

            return degree;
        }
        static void DisplayDegree()
        {
            foreach (var degree in DegreeProgram.OfferedDegree)
            {
                Console.WriteLine("Degree Title: " + degree.title);
            }
        }
        static List<DegreeProgram> AddPreferences()
        {
            List<DegreeProgram> Preferences = new List<DegreeProgram>();
            DisplayDegree();
            int maxPref;
            Console.Write("Enter how many Preferences you want to Apply: ");
            maxPref = int.Parse(Console.ReadLine());
            if (DegreeProgram.OfferedDegree.Count < maxPref)
            {
                maxPref = DegreeProgram.OfferedDegree.Count;
            }
            for (int j = 0; j < maxPref; j++)
            {
                Console.WriteLine("Enter the degree name to be added in Preference number " + (j + 1) + ": ");
                string dName = Console.ReadLine();
                int idx = DegreeProgram.IsDegreeExists(dName);
                if (idx != -1)
                {
                    Preferences.Add(DegreeProgram.OfferedDegree[idx]);
                }
                else
                {
                    Console.WriteLine("You have already added this degree as your Preference!");
                }
            }
            return Preferences;
        }
        static Student AddStudent()
        {
            string name;
            int age;
            float Fmarks, Emarks;
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter marks obtained in FSC: ");
            Fmarks = float.Parse(Console.ReadLine());
            Console.Write("Enter marks obtained in ECAT: ");
            Emarks = float.Parse(Console.ReadLine());
            List<DegreeProgram> Preferences = AddPreferences();
            Student s = new Student(name, age, Fmarks, Emarks, Preferences);
            return s;

        }
        static void SubjectDisplay(Subjects subject)
        {
            Console.WriteLine("Subject code: " + subject.code);
        }
        static void RegisterSubjects(int idx)
        {
            foreach (var subject in Student.students[idx].RegisteredDegree.OfferedSubjects)
            {
                SubjectDisplay(subject);
                Console.Write("Do you want to register in this subject: (Press Y to register) ");
                char sure = char.Parse(Console.ReadLine());
                if (Student.students[idx].TotalCH(subject) <= 9)
                {
                    if (sure == 'Y' || sure == 'y')
                    {
                        Student.students[idx].RegisteredSubjects.Add(subject);
                    }

                }
                else
                {
                    Console.WriteLine("You cannot add more subjects!!");
                }
            }

        }
        static void FeeDisplay()
        {
            float fee;
            foreach (var stu in Student.students)
            {
                fee = stu.GenerateFee();
                if (fee != -1)
                {
                    Console.WriteLine("Student name: " + stu.name + " fee: " + fee);
                }
            }
        }
        static void ViewRegisteredStudent()
        {
            foreach (var stu in Student.students)
            {
                if (stu.RegisteredStudent())
                {
                    Console.WriteLine("Student name: " + stu.name + " got Admission in: " + stu.RegisteredDegree.title);
                }
            }
        }
        static void ViewRegisteredStudentOfDegree(string degreeName)
        {
            foreach (var stu in Student.students)
            {
                if (stu.RegisteredStudentOfDegree(degreeName))
                {
                    Console.WriteLine("Student name: " + stu.name);
                }
            }
        }
        static void MeritList()
        {

            foreach (var stu in Student.students)
            {
                if (stu.IsApplicable() == true)
                {
                    Console.WriteLine("Student  " + stu.name + " got Admission in: " + stu.RegisteredDegree.title);
                }
                else
                {
                    Console.WriteLine("Student  " + stu.name + " did not  got Admission ");
                }
            }
        }
        static void Main(string[] args)
        {


            char op;
            while (true)
            {
                Console.Clear();
                op = Menu();
                if (op == '1')
                {
                    DegreeProgram degree = AddDegree();
                    DegreeProgram.AddDegreeInList(degree);
                }
                else if (op == '2')
                {
                    if (DegreeProgram.OfferedDegree.Count > 0)
                    {
                        Student stu = AddStudent();
                        Student.AddStudentInList(stu);
                    }
                    else
                    {
                        Console.WriteLine("You cannot add Student as there are no degree Pregrams added plz add one first");
                    }
                }
                else if (op == '3')
                {
                    if (Student.students.Count > 0)
                    {
                        Student.SortStudentList();
                        MeritList();
                    }
                }
                else if (op == '4')
                {
                    if (Student.students.Count > 0)
                    {
                        ViewRegisteredStudent();
                    }
                }
                else if (op == '5')
                {
                    if (Student.students.Count > 0)
                    {
                        Console.Write("Enter the name of degree: ");
                        string name = Console.ReadLine();
                        ViewRegisteredStudentOfDegree(name);
                    }
                }
                else if (op == '6')
                {
                    if (Student.students.Count > 0)
                    {
                        Console.WriteLine("Enter the name of student whose subjects you want to register: ");
                        string name = Console.ReadLine();
                        int idx = Student.isStudentAvailable(name);
                        if (idx != -1)
                        {
                            RegisterSubjects(idx);
                        }
                        else
                        {
                            Console.WriteLine("This student cannot Register any subject as he didn\'t got admission in any degree Program");
                        }
                    }

                }
                else if (op == '7')
                {
                    if (Student.students.Count > 0)
                    {
                        FeeDisplay();
                    }
                }
                else if (op == '8')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}