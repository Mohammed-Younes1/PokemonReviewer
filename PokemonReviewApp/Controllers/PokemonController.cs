using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;
using System.Collections.Generic;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository,IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
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
            var Pokemons = _mapper.Map<List<PokemonDto>>(_pokemonRepository.GetPokemons());
            if (Pokemons == null || !Pokemons.Any())
            {
                return NotFound(); // Return 404 if no pokemons are found
            }

            return Ok(Pokemons);
        }

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200,Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId) 
        { 
            if(!_pokemonRepository.PokemonExists(pokeId))
            {
                return NotFound();
            }
            var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemon(pokeId));
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemon);
        }

        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]

        public IActionResult GetPokemonRating(int pokeId)
        {
            if (!_pokemonRepository.PokemonExists(pokeId))
            {
                return NotFound();
            }
            var rating = _pokemonRepository.GetPokemonRating(pokeId);

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(rating);

        }

        //[HttpGet]
        //[ProducesResponseType(204)]
        //[ProducesResponseType(400)]

    }
}
