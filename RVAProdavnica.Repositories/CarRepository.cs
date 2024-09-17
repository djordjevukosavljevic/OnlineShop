using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Repositories
{
    public interface ICarRepository : IBaseRepository<Car>
    {

    }

    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(IConfiguration configuration) : base(configuration) 
        { 
            
        }

       
    }
}
