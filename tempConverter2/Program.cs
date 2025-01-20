using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert, intCelsius = 0, intFahrenheit = 0;
            double dblNumToConvert, dblCelsius = 0, dblFahrenheit = 0;
            bool stop = false;
            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();
                    while (!double.TryParse(numberToConvert, out dblNumToConvert) && !int.TryParse(numberToConvert, out intNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }
                    if (intNumToConvert > 0)
                    {
                        convertTemp(intNumToConvert, ref intCelsius, ref intFahrenheit);
                        Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to Celsius is {intCelsius}.00");
                        Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Fahrenheit is {intFahrenheit}.00");
                        intCelsius = 0;
                        intFahrenheit = 0;
                    }
                    else
                    {
                         convertTemp(dblNumToConvert, ref dblCelsius, ref dblFahrenheit);
                        Console.WriteLine($"{dblNumToConvert} degrees Fahrenheit converted to Celsius is {dblCelsius:F2}");
                        Console.WriteLine($"{dblNumToConvert} degrees Celsius converted to Fahrenheit is {dblFahrenheit:F2}");
                        dblCelsius = 0;
                        dblFahrenheit = 0;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;
                    while (!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Please enter a valid character, try again...");
                    }
                    if (Char.ToLower(more) != 'y')
                        stop = true;
                }
            } while (!stop);
        }

        private static void convertTemp(int intNumToConvert, ref int intCelsius, ref int intFahrenheit)
        {
            try
            {
                int celsius = (intNumToConvert - 32) * 5 / 9;
                int fahrenheit = (intNumToConvert * 9 / 5) + 32;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("There was a problem converting the temperature.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unknown error occurred when converting the temperature.");
                Console.WriteLine(e.Message);
            }
           return;
        }

        private static void convertTemp(double dblNumToConvert, ref double dblCelsius, ref double dblFahrenheit)
{
    try
        {
            dblCelsius = (dblNumToConvert - 32) * 5 / 9;  
            dblFahrenheit = (dblNumToConvert * 9 / 5) + 32;  
        }
    catch (ArithmeticException e)
        {
            Console.WriteLine("There was a problem converting the temperature.");
            Console.WriteLine(e.Message);
        }
    catch (Exception e)
        {
            Console.WriteLine("An unknown error occurred when converting the temperature.");
            Console.WriteLine(e.Message);
        }
}

        }
    }

