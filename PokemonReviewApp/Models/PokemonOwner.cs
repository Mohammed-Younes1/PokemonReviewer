using System;
namespace PokemonReviewApp.Models
{
	public class PokemonOwner
	{
		public int PokemonId { get; set; }
        public int OwnerId { get; set; }
		public Pokemon Pokemom { get; set; }
		public Owner Owner { get; set; }

	}
}

