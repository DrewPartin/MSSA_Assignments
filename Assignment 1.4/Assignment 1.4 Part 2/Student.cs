using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4_Part_2
{
    class Student
    {
        private int StudentID;
        private string StudentFname;
        private string StudentLname;
        private char StudentGrade;

        public int student_id
        {
            get
            {
                return StudentID;
            }
            set
            {
                this.StudentID = value;
            }
        }
        public string student_fname
        {
            get
            {
                return StudentFname;
            }
            set
            {
                this.StudentFname = value;
            }
        }
        public string student_lname
        {
            get
            {
                return StudentLname;
            }
            set
            {
                this.StudentLname = value;
            }
        }
        public char student_grade
        {
            get
            {
                return StudentGrade;
            }
            set
            {
                this.StudentGrade = value;
            }
        }

        public char CalculateGrade()
        {
            Console.Write("Please enter the student's grade percentage as a whole number: ");
            int percentage = Int32.Parse(Console.ReadLine());
            if(percentage > 89)
            {
                student_grade = 'A';
            }
            else if(percentage > 79)
            {
                student_grade = 'B';
            }
            else if(percentage > 69)
            {
                student_grade = 'C';
            }
            else if(percentage > 59)
            {
                student_grade = 'D';
            }
            else
            {
                student_grade = 'F';
            }
            return student_grade;
        }
    }
}
