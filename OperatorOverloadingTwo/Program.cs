namespace OperatorOverloadingEx1
{
    public class Employee
    {
        public int salary { get; set; }

        // Overload unary operators ++ and -- 
        // Code goes here
        public static Employee operator ++(Employee obj)
        {
            obj.salary++;
            return obj;
        }
        public static Employee operator --(Employee obj)
        {
            obj.salary--;
            return obj;
        }
        // Overload Comparison Operators > and <
        // Code goes here
        public static bool operator >(Employee lhs, Employee rhs)
        {
            return lhs.salary > rhs.salary;
        }
        public static bool operator <(Employee lhs, Employee rhs)
        {
            return lhs.salary < rhs.salary;
        }
        // Overload Binary Operators + and -
        // Code goes here
        public static Employee operator +(Employee lhs, Employee rhs)
        {
            return new Employee { salary = lhs.salary + rhs.salary };
        }

        public static Employee operator -(Employee lhs, Employee rhs)
        {
            return new Employee { salary = lhs.salary - rhs.salary };
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            // create object array
            Employee[] salarys = new Employee[10];
            // place random salarys into array and print values
            Console.Write("Original salarys= ");
            for (int i = 0; i < salarys.Length; i++)
            {
                salarys[i] = new Employee(); // creates the object
                salarys[i].salary = r.Next(10000, 1000000);  // places a value in the object
                Console.Write(" " + salarys[i].salary);
            }
            Console.WriteLine();
            // if divisible by 2, add 1 to value using operator ++ method
            // otherwise subtract 1 from value using operator -- method
            Console.Write("New salarys +1 or -1= ");
            for (int i = 0; i < salarys.Length; i++)
            {
                if (salarys[i].salary % 2 == 0)
                {
                    // Code goes here to increment salarys[i] by 1
                    salarys[i]++;
                }
                else
                {
                    // Code goes here to decrement salarys[i] by 1
                    salarys[i]--;
                }
                Console.Write(" " + salarys[i].salary);
            }   
            Console.WriteLine();

            // random Employee object to add
            Employee salToAdd = new Employee();
            salToAdd.salary = r.Next(10000, 100001);
            // Using operator +, adsal.salary to each element in the array
            // Print the results
            Console.Write($"salarys +{salToAdd.salary} = ");

            // Insert a for loop that addsal to salarys[i]
            for (int i = 0; i < salarys.Length; i++)
            {
            salarys[i] = salarys[i] + salToAdd;
            Console.Write(salarys[i].salary + " ");
            }
            Console.WriteLine();

            // random Employee object to subtract
            Employee salToSub = new Employee();
            salToSub.salary = r.Next(10000, 100001);
            // Using operator -, subtracsal.salary from each element in the array
            // Print the results
            Console.Write($"salarys - {salToSub.salary}= ");

            // Insert a for loop that subtractsal from salarys[i]
            for (int i = 0; i < salarys.Length; i++)
            {
            salarys[i] = salarys[i] - salToSub;
            Console.Write(salarys[i].salary + " ");
            }
            Console.WriteLine();

            // random Employee object for comparison
            Employee salToCompare = new Employee();
            salToCompare.salary = r.Next(10000, 100001);
            // Using operator > and operator <, compare each element tsal.salary
            // print if the element is higher, lower or equal to the salary you are comparing to
            Console.WriteLine($"salarys above or below {salToCompare.salary}");

           for (int i = 0; i < salarys.Length; i++)
            {
                if (salarys[i] > salToCompare) // Fixed: using the overloaded comparison operator
                {
                Console.WriteLine($"{salarys[i].salary} is higher.");
                }
                else if (salarys[i] < salToCompare)
                {
                Console.WriteLine($"{salarys[i].salary} is lower.");
                }
                else
                {
                Console.WriteLine($"{salarys[i].salary} is equal.");
                }
            }
            // Insert a for loop
            // Inside the for loop insert a nested if/else that checks salarys[i] > salaryToCompare
            // followed by a message that the salary is higher
            // Then it should check salarys[i] sal 
            // followed by a message that the salary is lower
            // if the salary isn't higher or lower, the message should indicate they are equal
        }
    }
}
