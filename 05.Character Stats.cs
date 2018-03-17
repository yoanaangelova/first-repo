using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int newEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int numberOfHealthDashes = currentHealth;
            string healthDashes = new string('|', numberOfHealthDashes);

            int numberOfHealthDots = maxHealth - currentHealth;
            string healthDots = new string('.', numberOfHealthDots);

            int numberOfEnergyDashes = currentEnergy;
            string energyDashes = new string('|', numberOfEnergyDashes);

            int numberOfEnergyDots = maxEnergy - currentEnergy;
            string energyDots = new string('.', numberOfEnergyDots);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthDashes}{healthDots}|");
            Console.WriteLine($"Energy: |{energyDashes}{energyDots}|");
        }
    }
}
