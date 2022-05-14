using System;
using System.Collections.Generic;
using System.Linq;

namespace T09.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Tournament")
                {
                    break;
                }

                var lineArgs = line.Split(' ');

                var trainerName = lineArgs[0];
                var pokemonName = lineArgs[1];
                var pokemonElement = lineArgs[2];
                var pokemonHealth = int.Parse(lineArgs[3]);

                var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainer.AddPokemon(pokemonName, pokemonElement, pokemonHealth); // if has equal pokemons ?
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (command == "Fire")
                {
                    PokemonAction(trainers, "Fire");
                }
                else if (command == "Water")
                {
                    PokemonAction(trainers, "Water");
                }
                else if (command == "Electricity")
                {
                    PokemonAction(trainers, "Electricity");
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer.ToString());
            }
        }
        private static void PokemonAction(List<Trainer> trainers, string command)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                }
            }
        }
    }
}
