using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player : GameCharacter
    {
        string[] inventory;

        public new void  ShowStats()  // overriding from gameCharacters
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("-----------------");
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Score: " + score);

        }

    }
}
