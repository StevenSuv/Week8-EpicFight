using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);

            Console.WriteLine($"{hero} will fight {villain}.");
            Console.WriteLine($"{hero} HP: {heroHP}");
            Console.WriteLine($"{villain} HP: {villainHP}");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}");

            while(heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, hero, heroWeapon);
                villainHP = villainHP - Hit(hero, villain, villainWeapon);
            }

            if(heroHP <= 0)
            {
                Console.WriteLine("Villains win!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }

        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spider-Man", "Spongebob", "Iron-Man" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];

        }

        private static int Hit(string characterOne, string characterTwo, string someWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someWeapon.Length / 2);

            Console.WriteLine($"{characterOne} hit {strike}.");
            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"{characterOne} made a critical hit!");
            }
            else if(strike == 0)
            {
                Console.WriteLine($"{characterTwo} dodged the attack!");
            }

            return strike;

        }

        private static int GenerateHP(string someName)
        {
            Random rnd = new Random();
            return rnd.Next(someName.Length, someName.Length + 10);
        }

        private static string PickVillain()
        {
            string[] superVillains = { "Darth Vader", "Joker", "Doctor Octupus", "Patrick", "Thanos" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);

            return superVillains[randomIndex];

        }
        private static string PickWeapon()
        {
            string[] weapon = { "Plastic Fork", "Banana", "Frying Pan", "Purse", "Flip-Flop" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];

        }

    }
}
