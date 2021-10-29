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
        /*Обсуждали, что аргумент Attacked необязателен, потому что если мы 
         вызываем метод у Fighter1, то он может сам обратиться к своим полям же
         То есть, Fight может выглядеть так:
         public void Fight(Fighter Attacking)
        {
            MinusHp(Attacking);            
        }
        */
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

        /*Логовые методы с выводом в логике лучше не содержать. Логика не содержит представления, представление - логики
        В данном случае, если очень хочется, можно сделать так, чтобы метод возвращал, строку, а что делать с этой строкой
        мы решаем уже в представлении
        */

        void OutAnInfoAboutPers()
        {
            Console.WriteLine($"У персонажа {_name} {_hp} hp и {_damage} ед. урона.");
        }
        //Аналогично с Attacked, как сказано выше. При вашей реализации нет смысла делать этот метод нестатическим,
        //потому что он не обращается к конкретным полям экземпляра класса (конкретного fighter1, например). То есть,
        //В вашей реализации нужно или делать эти методы статическими, и они будут принимать двух каких-то файтеров, или тогда убирать
        //аргумент, который обращается к конкретному экземпляру
        void OutAnInfoAboutFight(Fighter Attacked, Fighter Attacking)
        {
            Console.WriteLine($"{Attacking._name} ударил(-а) {Attacked._name} и нанёс(-ла) {Attacking._damage} ед. урона.");
            Console.WriteLine($"Теперь у {Attacked._name} {Attacked._hp} hp.");
        }
        //То, что свойства в конец вынесены - это хорошо и правильно)
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
