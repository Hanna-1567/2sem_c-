using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class GameLogger
    {
        public void Log(int damage, int hp)
        {
            Console.WriteLine($"[Logger] Damage: {damage}, HP left: {hp}");
        }
    }
}
