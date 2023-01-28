using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            Student[] st = new Student[size];
            int studentEntered = 0;
            while (true)
            {
                Console.Clear();
                char op = Menu();
                if (op == '1')
                {
                    if (studentEntered <= size)
                    {
                        st[studentEntered] = AddRecord();
                        studentEntered++;
                    }
                }
                else if (op == '2')
                {
                    Console.WriteLine("Name\t\tRollNo.\t\tCGPA\t\tisHostalide\t\tDepartment");
                    for (int i = 0; i < studentEntered; i++)
                    {
                        ShowData(st[i]);
                    }
                }
                else if (op == '3')
                {
                    Top3(st, studentEntered);
                }
                else if (op == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input!!");
                }
                Console.WriteLine("Enter any key to continue");
                Console.ReadKey();
            }
        }
        static void Sort(int[] idx, float[] cgpa, int size)
        {
            float[] temp = new float[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = cgpa[i];
                idx[i] = i;
            }
            for (int i = 0; i < size; i++)
            {
                float tem;
                for (int j = 0; j < size - 1; j++)
                {
                    tem = temp[j];
                    int itemp = idx[j];
                    if (tem < temp[j + 1])
                    {
                        temp[j] = temp[j + 1];
                        temp[j + 1] = tem;
                        idx[j] = idx[j + 1];
                        idx[j + 1] = itemp;
                    }
                }
            }
        }
        static void Top3(Student[] s, int size)
        {
            float[] cgpa = new float[size];
            int[] idx = new int[size];
            for (int i = 0; i < size; i++)
            {
                cgpa[i] = s[i].cgpa;
            }
            Sort(idx, cgpa, size);
            Console.WriteLine("Name\t\tRollNo.\t\tCGPA\t\tisHostalide\t\tDepartment");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(s[idx[i]].name + "\t\t" + s[idx[i]].rollNo + "\t\t" + s[idx[i]].cgpa + "\t\t" + s[idx[i]].isHostialide + "\t\t" + s[idx[i]].department);
            }
        }
        static void ShowData(Student s)
        {
            Console.WriteLine(s.name + "\t\t" + s.rollNo + "\t\t" + s.cgpa + "\t\t" + s.isHostialide + "\t\t" + s.department);
        }
        static Student AddRecord()
        {
            Student s = new Student();
            Console.Write("Enter name of Student: ");
            s.name = Console.ReadLine();
            Console.Write("Enter roll no. of student: ");
            s.rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA of student: ");
            s.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Is Student Hostalide or not(Y for yes and n for No): ");
            s.isHostialide = Console.ReadLine()[0];
            Console.Write("Enter department of Student: ");
            s.department = Console.ReadLine();
            return s;
        }
        static char Menu()
        {
            char op = ' ';
            Console.WriteLine("Press1 to add new student");
            Console.WriteLine("Press2 to show all Student");
            Console.WriteLine("Press3 to Show top3 students");
            Console.WriteLine("Press4 to Exit");
            op = Console.ReadLine()[0];
            return op;
        }
    }
}
