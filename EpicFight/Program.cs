using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}.");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}");
        }

        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spider-Man", "Spongebob", "Iron-Man" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];

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
