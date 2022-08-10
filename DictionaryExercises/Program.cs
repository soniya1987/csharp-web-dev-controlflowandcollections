using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students' names and ID numbers (or ENTER to finish):");

            Console.WriteLine("Student Name: ");
            newStudent = Console.ReadLine();

            if (newStudent != "")
            {
                Console.WriteLine("ID: ");
                int newID = int.Parse(Console.ReadLine());
                students.Add(newID, newStudent);
            }

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + "'s ID: " + student.Key);
            }

            Console.WriteLine("Number of students in roster: " + students.Count);
        }
    }
}
