public class Student
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
        IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major = "Hospitality", Tuition = 3500.00 },
            new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major = "Hospitality", Tuition = 4500.00 },
            new Student() { StudentID = 3, StudentName = "Cookie Crumb", Age = 21, Major = "CIT", Tuition = 2500.00 },
            new Student() { StudentID = 4, StudentName = "Ima Script", Age = 48, Major = "CIT", Tuition = 5500.00 },
            new Student() { StudentID = 5, StudentName = "Cora Coder", Age = 35, Major = "CIT", Tuition = 1500.00 },
            new Student() { StudentID = 6, StudentName = "Ura Goodchild", Age = 40, Major = "Marketing", Tuition = 500.00 },
            new Student() { StudentID = 7, StudentName = "Take Mewith", Age = 29, Major = "Aerospace Engineering", Tuition = 5500.00 }
        };

        // Student GPA collection
        IList<StudentGPA> studentGPAList = new List<StudentGPA>()
        {
            new StudentGPA() { StudentID = 1, GPA = 4.0 },
            new StudentGPA() { StudentID = 2, GPA = 3.5 },
            new StudentGPA() { StudentID = 3, GPA = 2.0 },
            new StudentGPA() { StudentID = 4, GPA = 1.5 },
            new StudentGPA() { StudentID = 5, GPA = 4.0 },
            new StudentGPA() { StudentID = 6, GPA = 2.5 },
            new StudentGPA() { StudentID = 7, GPA = 1.0 }
        };

        // Club collection
        IList<StudentClubs> studentClubList = new List<StudentClubs>()
        {
            new StudentClubs() { StudentID = 1, ClubName = "Photography" },
            new StudentClubs() { StudentID = 1, ClubName = "Game" },
            new StudentClubs() { StudentID = 2, ClubName = "Game" },
            new StudentClubs() { StudentID = 5, ClubName = "Photography" },
            new StudentClubs() { StudentID = 6, ClubName = "Game" },
            new StudentClubs() { StudentID = 7, ClubName = "Photography" },
            new StudentClubs() { StudentID = 3, ClubName = "PTK" }
        };

        var groupedByGPA = studentGPAList.GroupBy(s => s.GPA);
        Console.WriteLine("Grouped by GPA:");
        foreach (var group in groupedByGPA)
        {
            Console.WriteLine($"GPA: {group.Key}, IDs: {string.Join(", ", group.Select(s => s.StudentID))}");
        }

        var sortedByClub = studentClubList.OrderBy(s => s.ClubName).GroupBy(s => s.ClubName);
        Console.WriteLine("\nSorted and Grouped by Club:");
        foreach (var group in sortedByClub)
        {
            Console.WriteLine($"Club: {group.Key}, IDs: {string.Join(", ", group.Select(s => s.StudentID))}");
        }

        int count = studentGPAList.Count(s => s.GPA >= 2.5 && s.GPA <= 4.0);
        Console.WriteLine($"\nCount of students with GPA between 2.5 and 4.0: {count}");

        double avgTuition = studentList.Average(s => s.Tuition);
        Console.WriteLine($"\nAverage Tuition: {avgTuition:C}");

        var highestPayer = studentList.OrderByDescending(s => s.Tuition).First();
        Console.WriteLine($"\nHighest paying student: {highestPayer.StudentName}, Major: {highestPayer.Major}, Tuition: {highestPayer.Tuition:C}");

        var studentsWithGPA = from student in studentList
            join gpa in studentGPAList on student.StudentID equals gpa.StudentID
            select new { student.StudentName, student.Major, gpa.GPA };

        Console.WriteLine("\nStudents with GPA:");
        foreach (var student in studentsWithGPA)
        {
            Console.WriteLine($"Name: {student.StudentName}, Major: {student.Major}, GPA: {student.GPA}");
        }

        var gameClubMembers = from student in studentList
            join club in studentClubList on student.StudentID equals club.StudentID
            where club.ClubName == "Game"
            select student.StudentName;

        Console.WriteLine("\nGame Club Members:");
        foreach (var student in gameClubMembers)
        {
            Console.WriteLine(student);
        }
    }
}



