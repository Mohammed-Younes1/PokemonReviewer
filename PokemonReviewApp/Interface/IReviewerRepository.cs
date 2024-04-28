using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReview(int reviewerId);
        bool ReviewerExists(int reviewerId);
        bool CreateRewviewer(Reviewer reviewer);
        bool Save();

    }
}
