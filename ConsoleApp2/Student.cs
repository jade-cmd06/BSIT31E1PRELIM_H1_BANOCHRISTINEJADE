using System;

namespace StudentManagementSystem
{
    internal class Student
    {
        private string name;
        private int grade1;
        private int grade2;
        private int grade3;

        public Student(string name, int grade1, int grade2, int grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }

        public string GetName()
        {
            return name;
        }

        public int GetGrade1()
        {
            return grade1;
        }

        public int GetGrade2()
        {
            return grade2;
        }

        public int GetGrade3()
        {
            return grade3;
        }

        public double Average()
        {
            return (grade1 + grade2 + grade3) / 3.0;
        }
    }
}
