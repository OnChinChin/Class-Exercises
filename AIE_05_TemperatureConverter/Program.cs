using System;

namespace AIE_05_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius = 35;
            float celciusToFahrenheit = celcius / 5 * 9 + 32;

            Console.WriteLine($"{celcius} Celsius is {celciusToFahrenheit} Fahrenheit");

            float FahrenheitToCelcius = (celciusToFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{celciusToFahrenheit} Fahrenheit is {FahrenheitToCelcius} celcius");
            

        }
    }
}
