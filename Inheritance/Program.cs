using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inheritance");
            Console.WriteLine();
            Console.ReadKey(true);

            Player player = new Player();
            Enemy enemy = new Enemy();
            // GameCharacter gamecharacter = new GameCharacter(); // DONT DO THIS

            player.name = "Geoff";
            player.x = 15;
            player.y = 25;
            player.health = 10000;
            player.score = 86548960;

            enemy.name = "Steve";
            enemy.x = 30;
            enemy.y = 15;
            enemy.health = 999;

            player.ShowStats();
            Console.WriteLine();
            enemy.ShowStats();
            Console.WriteLine();

            Console.ReadKey(true);


        }
    }
}
