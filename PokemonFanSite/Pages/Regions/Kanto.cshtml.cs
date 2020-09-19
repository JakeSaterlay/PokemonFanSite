using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonFanSite.Core;
using PokemonFanSite.Data;

namespace PokemonFanSite.Pages.Regions
{
    public class KantoModel : PageModel
    {

        private readonly IPokemonData kantoData;
        public IEnumerable<Pokemon> Pokemon { get; set; }

        public KantoModel(IPokemonData kantoData)
        {
            this.kantoData = kantoData;
        }

        public void OnGet()
        {
            Pokemon = kantoData.GetAllKanto();
        }
    }
}