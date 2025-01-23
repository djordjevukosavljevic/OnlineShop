using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;

namespace RVAProdavnica.Repositories
{   
    public interface IReviewRepository : IBaseRepository<Review>
    {

    }

    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}