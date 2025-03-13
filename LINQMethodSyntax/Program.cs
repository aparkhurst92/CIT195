﻿public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
    public double Tuition { get; set; }
}

public class StudentClubs
{
    public int StudentID { get; set; }
    public string ClubName { get; set; }
}

public class StudentGPA
{
    public int StudentID { get; set; }
    public double GPA { get; set; }
}

class Program
{
    static void Main()
    {
        // Student collection
        List<Student> studentList = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00 },
            new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 },
            new Student() { StudentID = 3, StudentName = "Cookie Crumb", Age = 21, Major="CIT", Tuition=2500.00 },
            new Student() { StudentID = 4, StudentName = "Ima Script", Age = 48, Major="CIT", Tuition=5500.00 },
            new Student() { StudentID = 5, StudentName = "Cora Coder", Age = 35, Major="CIT", Tuition=1500.00 },
            new Student() { StudentID = 6, StudentName = "Ura Goodchild", Age = 40, Major="Marketing", Tuition=500.00 },
            new Student() { StudentID = 7, StudentName = "Take Mewith", Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
        };

        // Student GPA Collection
        List<StudentGPA> studentGPAList = new List<StudentGPA>()
        {
            new StudentGPA() { StudentID = 1, GPA=4.0 },
            new StudentGPA() { StudentID = 2, GPA=3.5 },
            new StudentGPA() { StudentID = 3, GPA=2.0 },
            new StudentGPA() { StudentID = 4, GPA=1.5 },
            new StudentGPA() { StudentID = 5, GPA=4.0 },
            new StudentGPA() { StudentID = 6, GPA=2.5 },
            new StudentGPA() { StudentID = 7, GPA=1.0 }
        };

        // Club collection
        List<StudentClubs> studentClubList = new List<StudentClubs>()
        {
            new StudentClubs() { StudentID = 1, ClubName="Photography" },
            new StudentClubs() { StudentID = 1, ClubName="Game" },
            new StudentClubs() { StudentID = 2, ClubName="Game" },
            new StudentClubs() { StudentID = 5, ClubName="Photography" },
            new StudentClubs() { StudentID = 6, ClubName="Game" },
            new StudentClubs() { StudentID = 7, ClubName="Photography" },
            new StudentClubs() { StudentID = 3, ClubName="PTK" }
        };

        var gpaGroups = studentGPAList.GroupBy(g => g.GPA);
        Console.WriteLine("Grouped by GPA:");
        foreach (var gpaGroup in gpaGroups)
        {
            Console.WriteLine($"GPA: {gpaGroup.Key}, IDs: {string.Join(", ", gpaGroup.Select(g => g.StudentID))}");
        }

        var clubsByName = studentClubList.GroupBy(c => c.ClubName);
        Console.WriteLine("\nSorted and Grouped by Club:");
        foreach (var clubGroup in clubsByName)
        {
            Console.WriteLine($"Club: {clubGroup.Key}, IDs: {string.Join(", ", clubGroup.Select(c => c.StudentID))}");
        }

        int countStudentsInGPARange = studentGPAList.Count(g => g.GPA >= 2.5 && g.GPA <= 4.0);
        Console.WriteLine($"\nCount of students with GPA between 2.5 and 4.0: {countStudentsInGPARange}");

        double averageTuitionCost = studentList.Average(st => st.Tuition);
        Console.WriteLine($"\nAvg Tuition: {averageTuitionCost:C}");

        var topTuitionPayingStudent = studentList.OrderByDescending(st => st.Tuition).First();
        Console.WriteLine($"\nHighest paying student: {topTuitionPayingStudent.StudentName}, Major: {topTuitionPayingStudent.Major}, Tuition: {topTuitionPayingStudent.Tuition:C}");

        var studentsGpaDetails = from st in studentList
        join sg in studentGPAList on st.StudentID equals sg.StudentID
        select new { st.StudentName, st.Major, sg.GPA };

        Console.WriteLine("\nStudents with GPA:");
        foreach (var studentDetail in studentsGpaDetails)
        {
            Console.WriteLine($"Name: {studentDetail.StudentName}, Major: {studentDetail.Major}, GPA: {studentDetail.GPA}");
        }

        var gameClubParticipantNames = from st in studentList
        join cl in studentClubList on st.StudentID equals cl.StudentID
        where cl.ClubName == "Game"
        select st.StudentName;

        Console.WriteLine("\nGame Club Members:");
        foreach (var gameMember in gameClubParticipantNames)
        {
            Console.WriteLine(gameMember);
        }
    }
}


