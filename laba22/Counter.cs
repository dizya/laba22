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
        public void Method(int _value)
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
}
