using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    class Student
    {
        public string Name { get; set; }
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }

        public double Average()
        {
            return (Grade1 + Grade2 + Grade3) / 3.0;
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== STUDENT SYSTEM =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Compute Average Grade");
                Console.WriteLine("4. Find Highest Grade");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        ViewStudents();
                        break;

                    case "3":
                        ComputeClassAverage();
                        break;

                    case "4":
                        FindHighestGrade();
                        break;

                    case "5":
                        Console.WriteLine("\n❌ Exit");
                        Console.WriteLine("Exiting program...");
                        Console.WriteLine("Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
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

            students.Add(new Student
            {
                Name = name,
                Grade1 = grade1,
                Grade2 = grade2,
                Grade3 = grade3
            });

            Console.WriteLine("Student added successfully!");
        }

        static void ViewStudents()
        {
            Console.WriteLine("\n📋 View Students");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Grades: {student.Grade1}, {student.Grade2}, {student.Grade3}");
                Console.WriteLine($"Average: {student.Average():F2}");
                Console.WriteLine();
            }
        }

        static void ComputeClassAverage()
        {
            Console.WriteLine("\n📊 Class Average");
            Console.WriteLine("===== CLASS AVERAGE =====");

            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            double overallAverage = students.Average(s => s.Average());

            Console.WriteLine($"Overall Average Grade: {overallAverage:F2}");
        }

        static void FindHighestGrade()
        {
            Console.WriteLine("\n🏆 Highest Grade");
            Console.WriteLine("===== HIGHEST GRADE =====");

            if (students.Count == 0)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            Student topStudent = null;
            int highestGrade = -1;

            foreach (Student student in students)
            {
                int studentHighest =
                    Math.Max(student.Grade1,
                    Math.Max(student.Grade2, student.Grade3));

                if (studentHighest > highestGrade)
                {
                    highestGrade = studentHighest;
                    topStudent = student;
                }
            }

            Console.WriteLine($"Top Student: {topStudent.Name}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
        }
    }
}
