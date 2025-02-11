using System;

namespace Employees
{
    // Interface IEmployee
    interface IEmployee
    {
        // Properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        // Methods
        string Fullname();
        double Pay();
    }

    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }

    class Worker : Employee
    {
        public double Rate { get; set; }
        public int Hours { get; set; }

        public Worker() : base()
        {
            Rate = 0;
            Hours = 0;
        }

        public Worker(int id, string firstName, string lastName, double rate, int hours)
            : base(id, firstName, lastName)
        {
            Rate = rate;
            Hours = hours;
        }

        sealed public override double Pay()
        {
            if (Hours > 40)
                return 40 * Rate + (1.5 * ((Hours - 40) * Rate));
            else
                return Rate * Hours;
        }
    }

    sealed class Executive : Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }

        public Executive() : base()
        {
            Title = string.Empty;
            Salary = 0;
        }

        public Executive(int id, string firstName, string lastName, string title, double salary)
            : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            return Salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Fullname()}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee george = new Employee(5, "George", "Jetson");
            george.Pay();
            Console.WriteLine();

            Worker fred = new Worker(10, "Fred", "Flintstone", 50, 60);
            Console.WriteLine(fred.Fullname());
            Console.WriteLine(fred.Pay());
            Console.WriteLine();

            Worker barney = new Worker();
            barney.Id = 20;
            barney.FirstName = "Barney";
            barney.LastName = "Rubble";
            barney.Rate = 40;
            barney.Hours = 75;
            Console.WriteLine(barney.Fullname());
            Console.WriteLine(barney.Pay());
            Console.WriteLine();

            Executive lebron = new Executive(8, "LeBron", "James", "Executive", 10000000);
            lebron.DisplayInfo();
            Console.WriteLine(lebron.Pay());
            Console.WriteLine();
        }
    }
}

    
