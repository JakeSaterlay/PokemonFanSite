using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonFanSite.Core;
using PokemonFanSite.Data;

namespace PokemonFanSite.Pages.PokemonData
{
    public class DetailModel : PageModel
    {
        private readonly IPokemonData pokemonData;
        public Pokemon Pokemon { get; set; }

        public DetailModel(IPokemonData pokemonData)
        {
            this.pokemonData = pokemonData;
        }
        public IActionResult OnGet(int pokemonId)
        {
            Pokemon = pokemonData.GetById(pokemonId);
            if(Pokemon == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}