using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class Display
    {
        public void ShowTemperature(double temperature)
        {
            Console.WriteLine($"Display: поточна температура {temperature}°C");
        }
    }
}
