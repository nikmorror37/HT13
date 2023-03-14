using System.Numerics;
using System.Text;
using System.Text.Json;

namespace HT13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (var fs = new FileStream("SuperHero.json", FileMode.OpenOrCreate))
            {
                var firstSuperHeroSquad = JsonSerializer.Deserialize<SHSquad>(fs);
                Console.WriteLine($"Имя состава: {firstSuperHeroSquad.SquadName}, " +
                            $"Место локации: {firstSuperHeroSquad.HomeTown}, " +
                            $"Основан: {firstSuperHeroSquad.WhenFormed}, " +
                            $"Секретная база: {firstSuperHeroSquad.SecretBase}, " +
                            $"Активность: {firstSuperHeroSquad.Activity}\n");
                Console.WriteLine("Участники состава: ");
                firstSuperHeroSquad.ShowMembers();
            }
        }
    }
}