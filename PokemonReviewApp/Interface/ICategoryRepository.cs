using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int CategoryId);
        bool CategoryExist(int id);
        bool CreateCategory(Category category);
        bool Save();
      
    }
}