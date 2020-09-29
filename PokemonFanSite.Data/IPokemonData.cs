using PokemonFanSite.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PokemonFanSite.Data
{
    public interface IPokemonData
    {
        IEnumerable<Pokemon> GetAllKanto();
        IEnumerable<Pokemon> GetPokemonByName(string name);
        Pokemon GetById(int id);
    }

    public class InMemoryPokemonData : IPokemonData
    {
        readonly List<Pokemon> pokemon;

        public InMemoryPokemonData()
        {
            pokemon = new List<Pokemon>()
            {
                new Pokemon { Id = 1, DexNumber = 1, Name = "Charmander", Type = PokemonType.Fire, Region = Regions.Kanto },
                new Pokemon { Id = 2, DexNumber = 2, Name = "Charmeleon", Type = PokemonType.Fire, Region = Regions.Kanto },
                new Pokemon { Id = 3, DexNumber = 3, Name = "Charizard", Type = PokemonType.Fire, Region = Regions.Kanto }
            };
        }

        public IEnumerable<Pokemon> GetPokemonByName(string name = null)
        {
            return from p in pokemon
                   where string.IsNullOrEmpty(name) || p.Name.StartsWith(name)
                   orderby p.Name
                   select p;
        }

        public IEnumerable<Pokemon> GetAllKanto()
        {
            return from p in pokemon
                   orderby p.DexNumber
                   where p.Region == Regions.Kanto
                   select p;
        }

        public Pokemon GetById(int id)
        {
            return pokemon.SingleOrDefault(x => x.Id == id);
        }
    }
}
