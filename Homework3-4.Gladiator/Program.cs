using System;

namespace Homework3_4.Gladiator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Привет!\nЭто игра \"Гладиаторские бои\".\nЕдиницы здоровья и урона генерируются случайным образом.\nОт Вас требуется только ввести имена персонажей и наблюдать исход:)");
            Fighter fighter_1 = new Fighter();
            Fighter fighter_2 = new Fighter();
            do
            {
                fighter_1.Fight(fighter_1, fighter_2);
                fighter_2.Fight(fighter_2, fighter_1);
            }
            while ((fighter_1.HP - fighter_2.DAMAGE) > 0 & (fighter_2.HP - fighter_1.DAMAGE) > 0);
            //Зачем вычитать дамаг? Почему не здоровье > 0?
        }
    }
}
