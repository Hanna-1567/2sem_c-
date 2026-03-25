using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
   class TemperatureSensor
    {
        private double temperature;

        public event Action<double> TemperatureChanged;

        public void SetTemperature(double newTemperature)
        {
            temperature = newTemperature;

            Console.WriteLine($"\nSensor: температура змінена на {temperature}°C");

            TemperatureChanged?.Invoke(temperature);
        }
    }

}
