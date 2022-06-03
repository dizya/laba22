using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    public class StepEnemy
    {
        public Random rndEnemy = new Random();
        public int kolvolosteyEnemy { get; set; }
        public int nominalEnemy { get; set; }
        public void Step()
        {
            kolvolosteyEnemy = rndEnemy.Next(1, 6);
            nominalEnemy = rndEnemy.Next(1, 7);
            Console.WriteLine($"Ставка костей соперника {kolvolosteyEnemy}");
            Console.WriteLine($"Ставка номинала костей соперника {nominalEnemy}");
        }
    }
}
