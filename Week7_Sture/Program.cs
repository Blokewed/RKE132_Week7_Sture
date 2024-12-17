using System;
namespace Week7_Sture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valige teisendus (C/F või F/C):");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "C/F")
            {
                Console.WriteLine("Sisestage temperatuur Celsiuse järgi:");
                double celsius = double.Parse(Console.ReadLine());
                ConvertToFahrenheit(celsius);
            }
            else if (choice == "F/C")
            {
                Console.WriteLine("Sisestage temperatuur Fahrenheiti järgi:");
                double fahrenheit = double.Parse(Console.ReadLine());
                ConvertToCelsius(fahrenheit);
            }
            else
            {
                Console.WriteLine("Vigane valik");
            }
        }
        static void ConvertToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} °F on {celsius} °C.");
        }
        static void ConvertToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"{celsius} °C on {fahrenheit} °F.");
        }
    }
}