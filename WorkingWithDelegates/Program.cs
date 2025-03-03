namespace Assignment8ex2
{   
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        public delegate double ProductDelegate(double a, double b);

        static void Main(string[] args)
        {
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1,num2)}");
            Console.WriteLine($" {num1} * {num2} = {answer.GetProduct(num1, num2)}");

            Action<double, double> calcSmaller = delegate (double x, double y) 
            { 
                answer.GetSmaller(x, y); 
            };
            calcSmaller(num1, num2);

            Func<double, double, double> calcSum = delegate (double x, double y) 
            { 
                return answer.GetSum(x, y); 
            };
            Console.WriteLine($"Sum: {calcSum(num1, num2)}");

            ProductDelegate calcProduct = new ProductDelegate(answer.GetProduct);
            Console.WriteLine($"Product: {calcProduct(num1, num2)}");
        }
    }
}

