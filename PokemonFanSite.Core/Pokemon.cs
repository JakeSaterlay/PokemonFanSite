using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonFanSite.Core
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public Regions Region { get; set; }
    }
}
