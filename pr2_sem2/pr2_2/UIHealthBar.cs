using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2._2._2
{
    public class UIHealthBar
    {
    public void Update(int damage, int hp)
        {
            Console.WriteLine($"[UI] Current HP: {hp}");
        }
    }
}

