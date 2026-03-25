using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class SoundSystem
    {
        public void PlaySound(int damage, int hp)
        {
            Console.WriteLine("[Sound] Damage sound ");

            if (hp <= 20)
                Console.WriteLine("[Sound] CRITICAL HP sound");
        }
    }
}
