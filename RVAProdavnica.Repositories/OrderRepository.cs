using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using RVAProdavnica.Data;

namespace RVAProdavnica.Repositories
{
    public interface IOrderRepository : IBaseRepository<Product>
    {

    }

    public class OrderRepository : BaseRepository<Product>, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration) : base(configuration)
        {
            
        }
    }
}