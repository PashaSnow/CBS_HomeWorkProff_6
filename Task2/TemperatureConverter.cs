using System;


/// <summary>
/// Это Task 2
/// </summary>
namespace TemperatureConverter
{
    public class TemperatureConverter
    {
        public double ToCelsius(double farangate)
        {
            // если температура ниже абсолютного нуля в фаренгейтах
            if (farangate < -459.67)
                farangate = -459.67;
            return (farangate - 32d) / 1.8d;
        }

        public double ToFahrenheit(double celsius)
        {
            // если температура ниже абсолютного нуля в цельсиях
            if (celsius < -273.15)
                celsius = -273.15;
            return (celsius * 1.8d) + 32;
        }
    }
}