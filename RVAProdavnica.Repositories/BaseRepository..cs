using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RVAProdavnica.Data;


namespace RVAProdavnica.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : Base
    {   
        List<TEntity> GetAll();

        TEntity GetOne(int id);

        TEntity GetByPrice(double Price);

        int? Create(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        List<TEntity> TableSearch(int pageNumber, int rowsPerPage, string conditions, string orderBy);
    }
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: Base
    {
        private readonly IConfiguration configuration;
        public string connectionString;
        public MySqlConnection connection;
        
        public BaseRepository(IConfiguration configuration)
        {
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        ///     Get all from any table.
        /// </summary>
        /// <returns></returns>
        /// 
        public List<TEntity> GetAll()
        {
            var results = connection.GetList<TEntity>().ToList();
            return results;
        }

        /// <summary>
        ///     Get one from any table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetOne(int id)
        {
            var result = connection.Get<TEntity>(id);
            return result;
        }

        /// <summary>
        ///     Insert method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int? Create(TEntity obj)
        {
            obj.DateCreatedAt = DateTime.Now;
            obj.DateUpdatedAt = DateTime.Now;
            var result = connection.Insert<TEntity>(obj);
            return result;
        }

        /// <summary>
        ///     Update method
        /// </summary>
        /// <param name="obj"></param>
        public void Update(TEntity obj)
        {
            obj.DateUpdatedAt = DateTime.Now;
            connection.Update(obj);
        }

        /// <summary>
        ///     Delete method
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(TEntity obj)
        {
            connection.Delete(obj);
        }

        /// <summary>
        ///     Table search for pagination()
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="rowsPerPage"></param>
        /// <param name="conditions"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<TEntity> TableSearch(int pageNumber, int rowsPerPage, string conditions, string orderBy)
        {
            return connection.GetListPaged<TEntity>(pageNumber, rowsPerPage, conditions, orderBy).ToList();
        }

        public TEntity GetByPrice(double Price)
        {
            var result = connection.Get<TEntity>(Price);

            return result;
        }
    


    }
}
 