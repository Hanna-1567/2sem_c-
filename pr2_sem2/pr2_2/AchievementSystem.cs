using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class AchievementSystem
    {
        public void Check(int damage, int hp)
        {
            if (hp <= 50)
                Console.WriteLine("[Achievement] Half Health unlocked");

            if (hp <= 0)
                Console.WriteLine("[Achievement] First Death unlocked");
        }
    }
}
