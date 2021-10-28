using System;

namespace Homework3_4.Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter_1 = new Fighter();
            Fighter fighter_2 = new Fighter();
            int hp_1 = fighter_1.MinusHp(fighter_1, fighter_2);
            int hp_2 = fighter_2.MinusHp(fighter_2, fighter_2);
            do
            {
                fighter_1.Fight(fighter_1, fighter_2);
                fighter_2.Fight(fighter_2, fighter_1);

            }
            while (hp_1 > 0 | hp_2 > 0);
        }
    }
}
