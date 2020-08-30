using System;

namespace TwoFightersOneWinner
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            Name = name;
            Health = health;
            DamagePerAttack = damagePerAttack;
        }
    }

    class Program
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            Fighter attacking = fighter1.Name == firstAttacker ? fighter1 : fighter2;

            while(fighter1.Health > 0 && fighter2.Health > 0)
            {
                if(attacking == fighter1)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    attacking = fighter2;
                } else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    attacking = fighter1;
                }
            }

            return fighter1.Health <= 0 ? fighter2.Name : fighter1.Name;
        }

        static void Main(string[] args)
        {
            Fighter lew = new Fighter("Lew", 10, 2);
            Fighter harry = new Fighter("Harry", 5, 4);

            Console.WriteLine(declareWinner(lew, harry, harry.Name));
            Console.ReadKey();
        }
    }
}
