using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200,Type= typeof(IEnumerable<Pokemon>))]

        //public IActionResult GetPokemon()
        //{
        //    var Pokemons = _pokemonRepository.GetPokemons();
        //    if (ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    return Ok(Pokemons);
        //}
        public IActionResult GetPokemon()
        {
            var Pokemons = _pokemonRepository.GetPokemons();
            if (Pokemons == null || !Pokemons.Any())
            {
                return NotFound(); // Return 404 if no pokemons are found
            }

            return Ok(Pokemons);
        }
    }
}
