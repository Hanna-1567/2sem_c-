using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    class Player
        {
            public int HP { get; private set; }

            public event Action<int, int> OnDamageTaken;

            public Player(int hp)
            {
                HP = hp;
            }

            public void TakeDamage(int damage)
            {
                HP -= damage;
                Console.WriteLine($"\n[Player] Took {damage} damage");

                OnDamageTaken?.Invoke(damage, HP);
            }
        }
}
