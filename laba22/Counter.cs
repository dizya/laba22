using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    public class Counter
    {
        public int counterOne = 0, counterTwo = 0, counterThree = 0, counterFour = 0, counterFive = 0, counterSix = 0;
        public virtual void Method(int _value)
        {
           //Счетчик костей
            switch (_value)
            {
                case 1:
                    counterOne++;
                    break;
                case 2:
                    counterTwo++;
                    break;
                case 3:
                    counterThree++;
                    break;
                case 4:
                    counterFour++;
                    break;
                case 5:
                    counterFive++;
                    break;
                case 6:
                    counterSix++;
                    break;
            }
        }
    }
    public class CounterEnemy : Counter
    {
        public int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0, counter5 = 0, counter6 = 0;
        public override void Method(int _value)
        {
            switch (_value)
            {
                case 1:
                    counter1++;
                    break;
                case 2:
                    counter2++;
                    break;
                case 3:
                    counter3++;
                    break;
                case 4:
                    counter4++;
                    break;
                case 5:
                    counter5++;
                    break;
                case 6:
                    counter6++;
                    break;
            }
        }
    }
}
