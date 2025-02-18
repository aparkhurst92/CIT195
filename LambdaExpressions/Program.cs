using System;

class LambdaExpressions
{
    static void Main()
    {
        Console.WriteLine("Enter a number bro:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter another one bro:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //addition
        Func<double, double, double> add = (x, y) => x + y;
        //multiplication
        Func<double, double, double> multiply = (x, y) => x * y;
        //comparing and finding smaller value
        Func<double, double, double> findSmaller = (x, y) => x < y ? x : y;

        //results
        Console.WriteLine($"Addition: {add(num1, num2)}");
        Console.WriteLine($"Multiplication: {multiply(num1, num2)}");
        Console.WriteLine($"Smaller value: {findSmaller(num1, num2)}");
    }
}

