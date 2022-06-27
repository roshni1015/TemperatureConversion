using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatureconversion
{
    public class TemperatureCel
    {
        double fahrenheit;
        double Celsius = 36;
        public void TemCel()
        {
            Console.WriteLine("Celsius: " + Celsius);
            fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.ReadLine();
        }
       
        
    }
}
