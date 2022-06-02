using System;

namespace laba22
{
    public class Game
    {
        Counter counter = new Counter();
        StepEnemy stepEnemy = new StepEnemy();
        public Game(Gamer gamer, Gamer enemy)
        {
            string gamerKosti = gamer.Peremeshivanie();
            Console.WriteLine("Ваши кости: " + gamerKosti);//вывод ваших костей
            string enemyKosti = enemy.Peremeshivanie();

            for (int i = 0; i < 5; i++)
            {
                counter.Method(gamer.kosti[i]);
                counter.MethodEnemy(enemy.kosti[i]);
            }

            Console.WriteLine("Пожалуйста сделайте вашу ставку");
            Console.Write("Введите количество костей : ");
            int kolvokosteyGamer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номинал костей : ");
            int nominalGamer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваша ставка {kolvokosteyGamer} кости с номиналом {nominalGamer}");

            Console.WriteLine(stepEnemy.Step());//ставка соперника

            while (true)
            {
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
                    Console.WriteLine(stepEnemy.Step()); //ставка соперника
                }
                if (TrueFalseEnd == 2)
                {
                    Console.WriteLine("Вскрываемся");
                    Console.WriteLine("Ваши кости: " + gamerKosti);
                    Console.WriteLine("Кости соперника: " + enemyKosti);
                    Console.WriteLine(counter.counterOneGamer + " кость(ей) с номиналом 1");
                    Console.WriteLine(counter.counterTwoGamer + " кость(ей) с номиналом 2");
                    Console.WriteLine(counter.counterThreeGamer + " кость(ей) с номиналом 3");
                    Console.WriteLine(counter.counterFourGamer + " кость(ей) с номиналом 4");
                    Console.WriteLine(counter.counterFiveGamer + " кость(ей) с номиналом 5");
                    Console.WriteLine(counter.counterSixGamer + " кость(ей) с номиналом 6");
                    Console.WriteLine();
                    Console.WriteLine(counter.counterOneEnemy + " кость(ей) с номиналом 1");
                    Console.WriteLine(counter.counterTwoEnemy + " кость(ей) с номиналом 2");
                    Console.WriteLine(counter.counterThreeEnemy + " кость(ей) с номиналом 3");
                    Console.WriteLine(counter.counterFourEnemy + " кость(ей) с номиналом 4");
                    Console.WriteLine(counter.counterFiveEnemy + " кость(ей) с номиналом 5");
                    Console.WriteLine(counter.counterSixEnemy + " кость(ей) с номиналом 6");

                    if (TrueFalseEnd == 3)
                    {
                        break;
                    }
                }

            }
        }
    }
}
