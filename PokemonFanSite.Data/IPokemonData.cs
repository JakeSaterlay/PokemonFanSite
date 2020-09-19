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

        public IEnumerable<Pokemon> GetAllKanto()
        {
            return from p in pokemon
                   orderby p.DexNumber
                   where p.Region == Regions.Kanto
                   select p;
        }

    }
}
