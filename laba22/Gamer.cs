using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba22
{
    public class Gamer
    {
        public int[] kosti = new int[5];

        public string Peremeshivanie()
        {
            Random random = new Random();
            int kost1 = random.Next(1, 7);
            int kost2 = random.Next(1, 7);
            int kost3 = random.Next(1, 7);
            int kost4 = random.Next(1, 7);
            int kost5 = random.Next(1, 7);

            kosti[0] = kost1;
            kosti[1] = kost2;
            kosti[2] = kost3;
            kosti[3] = kost4;
            kosti[4] = kost5;

            return $"{kosti[0]} {kosti[1]} {kosti[2]} {kosti[3]} {kosti[4]}";
        }
    }
}
