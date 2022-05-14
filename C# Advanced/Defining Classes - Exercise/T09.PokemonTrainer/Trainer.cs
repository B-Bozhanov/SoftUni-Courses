using System;
using System.Collections.Generic;
using System.Text;

namespace T09.PokemonTrainer
{
    internal class Trainer
    {
        public Trainer(string trainerName)
        {
            Name = trainerName;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void AddPokemon(string pokemonName, string pokemonElement, int pokemonHealth)
        {
            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            Pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            var trainer = $@"{Name} {Badges} {Pokemons.Count}";
            return trainer;
        }
    }
}
