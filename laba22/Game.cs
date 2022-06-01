using System;

namespace laba22
{
    public class Game
    {
        StepEnemy stepEnemy = new StepEnemy();
        Counter counter = new Counter();
        CounterEnemy counterEnemy = new CounterEnemy();

        public Game(Gamer gamer, Gamer enemy)
        {
            string gamerKosti = gamer.Peremeshivanie();
            Console.WriteLine("Ваши кости: " + gamerKosti);//вывод ваших костей
            string enemyKosti = gamer.Peremeshivanie();

            for (int i = 0; i < 5; i++)
            {
                counter.Method(gamer.kosti[i]);
                counterEnemy.Method(gamer.kosti[i]);
            }

            Console.WriteLine("Пожалуйста сделайте вашу ставку");
            Console.Write("Введите количество костей : ");
            int kolvokosteyGamer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номинал костей : ");
            int nominalGamer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваша ставка {kolvokosteyGamer} кости с номиналом {nominalGamer}");


            while (true)
            {
                stepEnemy.Step(); //ставка соперника

                Console.WriteLine("Выберите \"1\" если верите и \"2\" если не верите " +
                    "или напишите \" 3\" если хотите закончить игру");
                int TrueFalseEnd = Convert.ToInt32(Console.ReadLine());//выбор действия(верить/не верить или закончить игру)

                if (TrueFalseEnd == 1)
                {
                    Console.Write("Введите количество костей : ");
                    int kolvokostey2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите номинал костей : ");
                    int nominal2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ваша ставка {kolvokostey2} кости с номиналом {nominal2}");
                }
                if (TrueFalseEnd == 2)
                {
                    Console.WriteLine("Вскрываемся");
                    Console.WriteLine("Ваши кости: " + gamerKosti);
                    Console.WriteLine("Кости соперника: " + enemyKosti);
                    Console.WriteLine(counter.counterOne + " кость(ей) с номиналом 1");
                    Console.WriteLine(counter.counterTwo + " кость(ей) с номиналом 2");
                    Console.WriteLine(counter.counterThree + " кость(ей) с номиналом 3");
                    Console.WriteLine(counter.counterFour + " кость(ей) с номиналом 4");
                    Console.WriteLine(counter.counterFive + " кость(ей) с номиналом 5");
                    Console.WriteLine(counter.counterSix + " кость(ей) с номиналом 6");
                    Console.WriteLine();
                    Console.WriteLine(counterEnemy.counterOne + " кость(ей) с номиналом 1");
                    Console.WriteLine(counterEnemy.counterTwo + " кость(ей) с номиналом 2");
                    Console.WriteLine(counterEnemy.counterThree + " кость(ей) с номиналом 3");
                    Console.WriteLine(counterEnemy.counterFour + " кость(ей) с номиналом 4");
                    Console.WriteLine(counterEnemy.counterFive + " кость(ей) с номиналом 5");
                    Console.WriteLine(counterEnemy.counterSix + " кость(ей) с номиналом 6");
                }
                if (TrueFalseEnd == 3)
                {
                    Console.ReadLine();
                }
            }

        }
    }
}
