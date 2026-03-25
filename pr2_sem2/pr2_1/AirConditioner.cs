using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class AirConditioner
    {
        public void Update(double temperature)
        {
            if (temperature < 17)
                Console.WriteLine("AirConditioner: Увімкнено ОБІГРІВ");
            else if (temperature <= 25)
                Console.WriteLine("AirConditioner: Вимкнено");
            else
                Console.WriteLine("AirConditioner: Увімкнено ОХОЛОДЖЕННЯ");
        }
    }
}
