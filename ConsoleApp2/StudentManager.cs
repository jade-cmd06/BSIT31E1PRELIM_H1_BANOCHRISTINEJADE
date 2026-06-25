using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    internal class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void AddStudent()
        {
            Console.WriteLine("\n➕ Add Student Flow");

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter grade 1: ");
            int grade1 = int.Parse(Console.ReadLine());

            Console.Write("Enter grade 2: ");
            int grade2 = int.Parse(Console.ReadLine());

            Console.Write("Enter grade 3: ");
            int grade3 = int.Parse(Console.ReadLine());

            Student student = new Student(name, grade1, grade2, grade3);

            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        public void ViewStudents()
        {
            Console.WriteLine("\n📋 View Students");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.GetName()}");
                Console.WriteLine($"Grades: {student.GetGrade1()}, {student.GetGrade2()}, {student.GetGrade3()}");
                Console.WriteLine($"Average: {student.Average():F2}");
                Console.WriteLine();
            }
        }

        public void ComputeClassAverage()
        {
            Console.WriteLine("\n===== CLASS AVERAGE =====");

            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            double overallAverage = students.Average(student => student.Average());

            Console.WriteLine($"Overall Average Grade: {overallAverage:F2}");
        }

        public void FindHighestGrade()
        {
            Console.WriteLine("\n===== HIGHEST GRADE =====");

            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            Student topStudent = null;
            int highestGrade = -1;

            foreach (Student student in students)
            {
                int studentHighest = Math.Max(
                    student.GetGrade1(),
                    Math.Max(student.GetGrade2(), student.GetGrade3()));

                if (studentHighest > highestGrade)
                {
                    highestGrade = studentHighest;
                    topStudent = student;
                }
            }

            Console.WriteLine($"Top Student: {topStudent.GetName()}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
        }
    }
}
