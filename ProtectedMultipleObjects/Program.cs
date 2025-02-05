using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace Inheritance
{
    // Base Class
    class Customer
    {
        protected int _Id;
        protected string _FirstName;
        protected string _LastName;
        protected int _Age;

        // Default constructor
        public Customer()
        {
            _Id = 0;
            _FirstName = string.Empty;
            _LastName = string.Empty;
            _Age = 0;
        }

        // Parameterized constructor
        public Customer(int id, string firstName, string lastName, int age)
        {
            _Id = id;
            _FirstName = firstName;
            _LastName = lastName;
            _Age = age;
        }

        public virtual void addChange()
        {
            Console.Write("ID=");
            _Id = int.Parse(Console.ReadLine());
            Console.Write("First Name=");
            _FirstName = Console.ReadLine();
            Console.Write("Last Name=");
            _LastName = Console.ReadLine();
            Console.Write("Age=");
            _Age = int.Parse(Console.ReadLine());
        }

        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"      ID: {_Id}");
            Console.WriteLine($"    Name: {_FirstName} {_LastName}");
            Console.WriteLine($"     Age: {_Age}");
        }
    }

    class PremiumCustomer : Customer
    {
        protected double _Salary;
        protected string _Location;

        // Default constructor
        public PremiumCustomer() : base()
        {
            _Salary = 0;
            _Location = string.Empty;
        }

        // Parameterized constructor
        public PremiumCustomer(int id, string firstName, string lastName, int age, double salary, string location)
            : base(id, firstName, lastName, age)
        {
            _Salary = salary;
            _Location = location;
        }

        public override void addChange()
        {
            base.addChange();
            Console.Write("Salary=");
            _Salary = double.Parse(Console.ReadLine());
            Console.Write("Location=");
            _Location = Console.ReadLine();
        }

        public override void print()
        {
            base.print();
            Console.WriteLine($"  Salary: {_Salary}");
            Console.WriteLine($"Location: {_Location}");
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

            // Array of Customer objects
            Customer[] customers = new Customer[maxCustomers];

            Console.WriteLine("How many Premium Customers do you want to enter?");
            int maxPremium;
            while (!int.TryParse(Console.ReadLine(), out maxPremium))
                Console.WriteLine("Please enter a whole number");

            // Array of PremiumCustomer objects
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
                            if (type == 1) // Premium Customer
                            {
                                if (premCounter < maxPremium)
                                {
                                    premiumCustomers[premCounter] = new PremiumCustomer();
                                    premiumCustomers[premCounter].addChange();
                                    premCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of premium customers has been added.");
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
                                    Console.WriteLine("The maximum number of customers has been added.");
                            }
                            break;

                        case 2: // Change
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;  // Subtract 1 because array index begins at 0

                            if (type == 1) // Premium Customer
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
                            if (type == 1) // Premium Customers
                            {
                                for (int i = 0; i < premCounter; i++)
                                    premiumCustomers[i].print();
                            }
                            else // Regular Customers
                            {
                                for (int i = 0; i < custCounter; i++)
                                    customers[i].print();
                            }
                            break;

                        default:
                            Console.WriteLine("You made an invalid selection, please try again.");
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


