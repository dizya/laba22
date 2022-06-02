using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    public class Counter
    {
        public int counterOneGamer = 0, counterTwoGamer = 0, counterThreeGamer = 0,
            counterFourGamer = 0, counterFiveGamer = 0, counterSixGamer = 0;
        public void Method(int _value)
        {
           //Счетчик костей игрока
            switch (_value)
            {
                case 1:
                    counterOneGamer++;
                    break;
                case 2:
                    counterTwoGamer++;
                    break;
                case 3:
                    counterThreeGamer++;
                    break;
                case 4:
                    counterFourGamer++;
                    break;
                case 5:
                    counterFiveGamer++;
                    break;
                case 6:
                    counterSixGamer++;
                    break;
            }
        }
        
        public int counterOneEnemy = 0, counterTwoEnemy = 0, counterThreeEnemy = 0, 
            counterFourEnemy = 0, counterFiveEnemy = 0, counterSixEnemy = 0;
        public void MethodEnemy(int value)
        {
            //Счетчик костей соперника
            switch (value)
            {
                case 1:
                    counterOneEnemy++;
                    break;
                case 2:
                    counterTwoEnemy++;
                    break;
                case 3:
                    counterThreeEnemy++;
                    break;
                case 4:
                    counterFourEnemy++;
                    break;
                case 5:
                    counterFiveEnemy++;
                    break;
                case 6:
                    counterSixEnemy++;
                    break;
            }
        }
    }
}
