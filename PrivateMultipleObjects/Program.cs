using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace Inheritance
{
    //Base Class
    class Customer
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private int _Age;

        // default constructor
        public Customer()
        {
            _Id = 0;
            _FirstName = string.Empty;
            _LastName = string.Empty;
            _Age = 0;
        }
        //parameterized constructor
        public Customer(int id, string firstName, string lastName, int age)
        {
            _Id = id;
            _FirstName = firstName;
            _LastName = lastName;
            _Age = age;
        }
        // Get and Set Methods
        public int getID() { return _Id; }
        public string getFirstName() { return _FirstName; }
        public string getLastName() { return _LastName; }
        public int getAge() { return _Age; }
        public void setID(int id) { _Id = id; }
        public void setFirstName(string firstName) { _FirstName = firstName; }
        public void setLastName(string lastName) { _LastName = lastName; }
        public void setAge(int age) { _Age = age; }

        public virtual void addChange()
        {
            Console.Write("ID=");
            setID(int.Parse(Console.ReadLine()));
            Console.Write("First Name=");
            setFirstName(Console.ReadLine());
            Console.Write("Last Name=");
            setLastName(Console.ReadLine());
            Console.Write("Age=");
            setAge(int.Parse(Console.ReadLine()));
        }
        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($" ID: {getID()}");
            Console.WriteLine($" Name: {getFirstName()} {getLastName()}");
            Console.WriteLine($" Age: {getAge()}");
        }
    }

    class PremiumCustomer : Customer
    {
        private double _Salary;
        private string _Location;

        public PremiumCustomer()
            : base()
        {
            _Location = string.Empty;
            _Salary = 0;
        }
        public PremiumCustomer(int id, string firstname, string lastname, int age, double salary, string location)
            : base(id, firstname, lastname, age)
        {
            _Salary = salary;
            _Location = location;
        }
        public void setSalary(double salary) { _Salary = salary; }
        public void setLocation(string location) { _Location = location; }
        public double getSalary() { return _Salary; }
        public string getLocation() { return _Location; }
        public override void addChange()
        {
            base.addChange();
            Console.Write("Salary=");
            setSalary(double.Parse(Console.ReadLine()));
            Console.Write("Location=");
            setLocation(Console.ReadLine());
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"  Salary: {getSalary()}");
            Console.WriteLine($"Location: {getLocation()}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many customers do you want to enter?");
            int maxCustomers;
            while (!int.TryParse(Console.ReadLine(), out maxCustomers))
                Console.WriteLine("Please enter a whole number");
            // array of Customer objects
            Customer[] customers = new Customer[maxCustomers];

            Console.WriteLine("How many Premium Customers do you want to enter?");
            int maxPremium;
            while (!int.TryParse(Console.ReadLine(), out maxPremium))
                Console.WriteLine("Please enter a whole number");
            // array of PremiumCustomer objects
            PremiumCustomer[] premiumCustomers = new PremiumCustomer[maxPremium];

            int choice, rec, type;
            int custCounter = 0, premCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for Premium Customer or 2 for Regular Customer");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for Premium Customer or 2 for Regular Customer");
                try
                {
                    switch (choice)
                    {
                        case 1: // Add
                            if (type == 1) // PremiumCustomer
                            {
                                if (premCounter < maxPremium)
                                {
                                    premiumCustomers[premCounter] = new PremiumCustomer();
                                    premiumCustomers[premCounter].addChange();
                                    premCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of premium customers has been added");
                            }
                            else // Regular Customer
                            {
                                if (custCounter < maxCustomers)
                                {
                                    customers[custCounter] = new Customer();
                                    customers[custCounter].addChange();
                                    custCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of customers has been added");
                            }
                            break;
                        case 2: //Change
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;  // subtract 1 because array index begins at 0
                            if (type == 1) // PremiumCustomer
                            {
                                while (rec >= premCounter || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again: ");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                premiumCustomers[rec].addChange();
                            }
                            else // Regular Customer
                            {
                                while (rec >= custCounter || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again: ");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                customers[rec].addChange();
                            }
                            break;
                        case 3: // Print All
                            if (type == 1) // PremiumCustomer
                            {
                                for (int i = 0; i < premCounter; i++)
                                    premiumCustomers[i].print();
                            }
                            else // Regular Customer
                            {
                                for (int i = 0; i < custCounter; i++)
                                    customers[i].print();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();
            }
        }

        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}

