using System;
using System.Collections.Generic;

namespace StudentInformationApp
{
    class Program
    {
        public class Student
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }

            public int Age
            {
                get
                {
                    var today = DateTime.Today;
                    int age = today.Year - DateOfBirth.Year;
                    if (DateOfBirth.Date > today.AddYears(-age)) age--;
                    return age;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = "24-668", Name = "Adora, Christian Mateo Perez", DateOfBirth = new DateTime(2007, 6, 17) },
                new Student { Id = "24-748", Name = "See, Isaiah Will So", DateOfBirth = new DateTime(2008, 2, 24) },
                new Student { Id = "24-752", Name = "Manzano, Arjan Jhames Alpas", DateOfBirth = new DateTime(2007, 10, 12) },
                new Student { Id = "24-677", Name = "Galo, Ariane Ignacio", DateOfBirth = new DateTime(2004, 09, 21) },
                new Student { Id = "24-664", Name = "Isidoro, Jared Carlo Garcia", DateOfBirth = new DateTime(2007, 7, 30) }
            };

            Console.WriteLine("Welcome to the Student Information App!");
            Console.WriteLine("ID Numbers: 24-668, 24-748, 24-752, 24-677, 24-664");

            while (true)
            {
                Console.WriteLine("Please enter a Student ID Number to view details:");
                string input = Console.ReadLine();

                Student student = students.Find(s => s.Id.Equals(input, StringComparison.OrdinalIgnoreCase));
                if (student != null)
                {
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
                    Console.WriteLine($"Age: {student.Age}");
                    break;
                }
                else
                {
                    Console.WriteLine("Student not found. Please enter a valid Student ID.");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
