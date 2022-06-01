using System;

namespace laba22
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            Gamer enemy = new Gamer();
            Game game = new Game(gamer, enemy);
        }
    }
}
