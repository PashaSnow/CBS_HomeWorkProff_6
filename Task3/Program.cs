using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly assembly = Assembly.Load("TemperatureConverter");
                Type myType = assembly.GetType("TemperatureConverter.TemperatureConverter");

                // зададим приблизительные температуры
                double inCelsius = 25d;
                double inFahrenheit = 73d;

                dynamic inst = Activator.CreateInstance(myType);
                Console.WriteLine("В фаренгейтах = {0} - в цельсиях = {1:#.#}", inFahrenheit, inst.ToCelsius(inFahrenheit));
                Console.WriteLine("В цельсиях = {0} - в фаренгейтах = {1:#.#}", inFahrenheit, inst.ToFahrenheit(inCelsius));
                Console.ReadKey();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
