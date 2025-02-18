using System;

namespace BusinessAuditorExample
{
    class Auditor
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    class Business
    {
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string BusinessAddress { get; set; }
        public Auditor Auditor { get; set; }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Business Information");
            Console.WriteLine("Business Name: " + BusinessName);
            Console.WriteLine("Business Type: " + BusinessType);
            Console.WriteLine("Business Address: " + BusinessAddress);
            Console.WriteLine("Auditor Information");
            Console.WriteLine("Name: " + Auditor.Name);
            Console.WriteLine("Phone: " + Auditor.Phone);
            Console.ResetColor();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Business and Auditor Example");

            //Auditor object
            Auditor auditor = new Auditor
            {
                Name = "Lebron James",
                Phone = "404-444-6967"
            };

            //Business object
            Business business = new Business
            {
                BusinessName = "Lebron James Hoop Shop",
                BusinessType = "Sports Shop",
                BusinessAddress = "3 Point St, Grand Rapids, MI 20039",
                Auditor = auditor
            };

            business.Display();
        }
    }
}


