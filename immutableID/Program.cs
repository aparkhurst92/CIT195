using System;
namespace Demo
{
class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        public Student(int id)
        {
            Id = id;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        
        public static void Main()
        {
            Student student1 = new Student(1);
            student1.FirstName = "Kamala";
            student1.LastName = "Joe";

            Student student2 = new Student(2, "Trump", "Harris");

            Console.WriteLine($"Student 1: ID = {student1.Id}, Name = {student1.FirstName} {student1.LastName}");
            Console.WriteLine($"Student 2: ID = {student2.Id}, Name = {student2.FirstName} {student2.LastName}");
        }
    }
}