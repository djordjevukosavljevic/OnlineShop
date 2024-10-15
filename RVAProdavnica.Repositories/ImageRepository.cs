using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;

namespace RVAProdavnica.Repositories
{

    public interface IImageRepository : IBaseRepository<Image>
    {

    }

    public class ImageRepository : IBaseRepository<Image>, IImageRepository
    {

        // public ImageRepository(IConfiguration configuration) : base(configuration)
        // {

        // }
        public int? Create(Image obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Image obj)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetByPrice(double Price)
        {
            throw new NotImplementedException();
        }

        public Image GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> TableSearch(int pageNumber, int rowsPerPage, string conditions, string orderBy)
        {
            throw new NotImplementedException();
        }

        public void Update(Image obj)
        {
            throw new NotImplementedException();
        }
    }
}