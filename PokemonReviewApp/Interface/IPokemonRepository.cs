using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int PokeId);
        bool PokemonExists(int IPokeId);
        bool CreatePokemon(int ownerId,int categoryId,Pokemon pokemon);
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        bool Save();
    }
}
