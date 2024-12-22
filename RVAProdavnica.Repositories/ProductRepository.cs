using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        
    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {
            
        }
    }
}
