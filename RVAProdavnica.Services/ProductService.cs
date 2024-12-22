using AutoMapper;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;

namespace RVAProdavnica.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll();

        ProductModel getById(int id);

        ProductModel getByPrice(double Price);

        List<ProductModel> TableSearch(int pageNumber, int rowsPerPage, string search);

        int? Create(ProductModel obj);

        void Update(ProductModel obj);

        void Delete(Product obj);

    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        /// <summary>
        ///     Create
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int? Create(ProductModel obj)
        {
            return productRepository.Create(mapper.Map<Product>(obj));
        }

        /// <summary>
        ///     Read
        /// </summary>
        /// <returns></returns>
        public List<ProductModel> GetAll()
        {
            var resultFromDb = productRepository.GetAll();
            var resultModels = mapper.Map<List<ProductModel>>(resultFromDb);
            return resultModels;
        }

        /// <summary>
        ///     Read by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public ProductModel getById(int id)
        {
            return mapper.Map<ProductModel>(productRepository.GetOne(id));
        }

        /// <summary>
        ///     Update
        /// </summary>
        /// <param name="obj"></param>
        public void Update(ProductModel obj)
        {
            productRepository.Update(mapper.Map<Product>(obj));
        }

        /// <summary>
        ///         Delete
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Product obj)
        {
            productRepository.Delete(obj);
            Console.WriteLine("Uspesno obrisano!");
        }

        /// <summary>
        ///     Table Search 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="rowsPerPage"></param>
        /// <param name="conditions"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<ProductModel> TableSearch(int pageNumber, int rowsPerPage, string search)
        {
            if (rowsPerPage > 100)
            {
                rowsPerPage = 100;
            }

            var resultFromDb = productRepository.TableSearch(pageNumber, rowsPerPage, $"WHERE Name like '%{search}%' or Description like '%{search}%'", "");
            var resultModels = mapper.Map<List<ProductModel>>(resultFromDb);

            return resultModels;
        }

        public ProductModel getByPrice(double Price)
        {
            return mapper.Map<ProductModel>(productRepository.GetByPrice(Price));
        }
    }
}