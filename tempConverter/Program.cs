using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert;
            double dblNumToConvert;
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
                        convertTemp(intNumToConvert);
                    }
                    else
                    {
                        convertTemp(dblNumToConvert);
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

        private static void convertTemp(int intNumToConvert)
        {
            try
            {
                int celsius = (intNumToConvert - 32) * 5 / 9;
                int fahrenheit = (intNumToConvert * 9 / 5) + 32;

                Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to Celsius is {celsius}.00");
                Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Fahrenheit is {fahrenheit}.00");
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
            finally
            {
                if (intNumToConvert == 0)
                {
                    Console.WriteLine("The temperature couldn't be converted.");
                }
            }
        }

        private static void convertTemp(double dblNumToConvert)
        {
            try
            {
                double celsius = (dblNumToConvert - 32) * 5 / 9;
                double fahrenheit = (dblNumToConvert * 9 / 5) + 32;

                Console.WriteLine($"{dblNumToConvert} degrees Fahrenheit converted to Celsius is {celsius:F2}");
                Console.WriteLine($"{dblNumToConvert} degrees Celsius converted to Fahrenheit is {fahrenheit:F2}");
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
            finally
            {
                if (dblNumToConvert == 0)
                {
                    Console.WriteLine("The temperature couldn't be converted.");
                }
            }
        }
    }
}

