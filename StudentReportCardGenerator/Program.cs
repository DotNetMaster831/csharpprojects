using System;
using System.Data;
using System.Security.Cryptography;

namespace StudentReportCardGenerator
{
    public class Program
    {
        //1. class & object
        //2. properties
        //3. methods
        //4. if else and switch
        //console i/o
        //loops
        

        public static void Main(string[] args)
        {
            Console.Title = "Student Report Card";

            Console.WriteLine("STUDENT REPORT CARD");
            Console.WriteLine("Student Accedamics monitor card");

            Console.WriteLine("Enter name of the Student");
            string name = Console.ReadLine();

            Console.WriteLine("Enter roll no of the Student");
            int rollNo =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter subject 1");
            double sub1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter subject 2");
            double sub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter subject 3");
            double sub3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter subject 4");
            double sub4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter subject 5");
            double sub5 = Convert.ToDouble(Console.ReadLine());

            //object
            Student s1 = new Student(name, rollNo);

            s1.subjectMarks[0] = sub1;
            s1.subjectMarks[1] = sub2;
            s1.subjectMarks[2] = sub3;
            s1.subjectMarks[3] = sub4;
            s1.subjectMarks[4] = sub5;


            double total = s1.GetTotal();


            double avg = s1.GetAvg();


            s1.GetReportCard();









            Console.ReadKey();
        }
      
    }

    //class creation
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RoolNo;
        public double[] subjectMarks = new double[10];
        public double Total { get; set; }
        public double Avg { get; set; }



        public Student(string name, int roll)
        {
            Name = name;
            RoolNo = roll;
        }

        public double GetTotal()
        {
           
            Total = subjectMarks[0] + subjectMarks[1] +
                subjectMarks[2] + subjectMarks[3] + subjectMarks[4];
            return Total;
        }

        public double GetAvg()
        {
            Avg = Total/ subjectMarks.Length;
            return Avg;
        }


        public char GetGrade()
        {
            if (Avg > 90)
                return 'A';
            else if (Avg > 80)
                return 'B';
            else if (Avg > 65)
               return 'C';
            else
            {
               return 'f';
            }


        }

        public void GetReportCard()
        {
            Console.WriteLine("=====REPORT CARD=====");
            Console.WriteLine(Name);
            Console.WriteLine(RoolNo);
            Console.WriteLine(Total);
            Console.WriteLine(Avg);

            char grade = GetGrade();


            Console.WriteLine(grade);
        }

    }
}