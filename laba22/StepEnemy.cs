using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    public class StepEnemy
    {
        Random rndEnemy = new Random();
        public void Step()
        {
            int kolvokosteyEnemy = rndEnemy.Next(1, 6);
            int nominalEnemy = rndEnemy.Next(1, 7);

            Console.WriteLine($"Ставка врага {kolvokosteyEnemy} кости(ей) с номиналом {nominalEnemy}");
        }
    }
}
