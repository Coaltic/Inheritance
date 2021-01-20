using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class GameCharacter
    {
        public string name;
        public int x;
        public int y;
        public int health;
        public int score;


        public void ShowStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("-----------------");
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Health: " + health);

        }
    }
}
