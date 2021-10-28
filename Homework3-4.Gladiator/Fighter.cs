using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_4.Gladiator
{
    class Fighter
    {
        int _hp, _damage;
        string _name;
        Random rnd = new Random();

        public Fighter()
        {
            _name = Console.ReadLine();
            _hp = rnd.Next(10,101);
            _damage = rnd.Next(1, 21);
            OutInfoAboutPers();
        }

        public void Fight(Fighter Attacked, Fighter Attacking)
        {
            MinusHp(Attacked, Attacking);
            OutInfoAboutFight(Attacked, Attacking);
        }
        public int MinusHp(Fighter Attacked, Fighter Attacking)
        {
            Attacked._hp -= Attacking._damage;
            return _hp;
        }

        void OutInfoAboutPers()
        {
            Console.WriteLine($"У {_name} {_hp} hp и {_damage} ед. урона.");
        }

        void OutInfoAboutFight(Fighter Attacked, Fighter Attacking)
        {
            Console.WriteLine($"{Attacking._name} ударил {Attacked._name} и нанёс ему {Attacking._damage} урона.");
            Console.WriteLine($"Теперь у {Attacked._name} {Attacked._hp} hp.");
        }
    }
}
