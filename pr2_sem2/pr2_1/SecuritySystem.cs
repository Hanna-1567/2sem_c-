using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class SecuritySystem
    {
        public void CheckTemperature(double temperature)
        {
            if (temperature > 40)
                Console.WriteLine("Security:Перегрів системи!");
            else if (temperature < 5)
                Console.WriteLine("Security:Ризик замерзання!");
        }
    }
}
