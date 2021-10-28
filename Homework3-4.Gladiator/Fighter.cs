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
            OutAnInfoAboutPers();
        }

        public void Fight(Fighter Attacked, Fighter Attacking)
        {
            MinusHp(Attacking);
            OutAnInfoAboutFight(Attacked, Attacking);
            OutAWinMessage(Attacking);
        }
        public void MinusHp(Fighter Attacking)
        {
            _hp -= Attacking._damage;
        }

        void OutAnInfoAboutPers()
        {
            Console.WriteLine($"У персонажа {_name} {_hp} hp и {_damage} ед. урона.");
        }

        void OutAnInfoAboutFight(Fighter Attacked, Fighter Attacking)
        {
            Console.WriteLine($"{Attacking._name} ударил(-а) {Attacked._name} и нанёс(-ла) {Attacking._damage} ед. урона.");
            Console.WriteLine($"Теперь у {Attacked._name} {Attacked._hp} hp.");
        }

        public int HP
        {
            get
            {
                return _hp;
            }
        }

        public int DAMAGE
        {
            get
            {
                return _damage;
            }
        }

        void OutAWinMessage(Fighter Attacking)
        {
            if ((_hp - Attacking._damage) <=0 )
            {
                Console.WriteLine($"{Attacking._name} одержал(-а) победу в этой славной битве!");
            }
        }
    }
}
