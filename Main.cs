using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Which of the following do you require?");
            Console.WriteLine("1. Celcius to Fahrenheit");
            Console.WriteLine("2. Celcius to Kelvin");
            Console.WriteLine("3. Fahrenheit to Celcius");
            Console.WriteLine("4. Fahrenheit to Kelvin");
            Console.WriteLine("5. Kelvin to Celcius");
            Console.WriteLine("6. Kelvin to Fahrenheit");
            Console.Write("Please enter the appropriate number: ");
            string fromChoice = Console.ReadLine();

            Console.Clear();

            Console.Write("What is the value you are converting from: ");
            string fromValue = Console.ReadLine();
            float valueAsFloat;

            Console.Clear();

            if (float.TryParse(fromValue, out valueAsFloat))
            {
                Temperatures tempConverter = new Temperatures(fromChoice, valueAsFloat);
                tempConverter.DoConversion();
                Console.WriteLine($"Your converted temperature is {tempConverter.ConvertedTempResult}.");
            }
            else
            {
                Console.WriteLine("The value given could not be converted.");
            }
        }
    }
}
