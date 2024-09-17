using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Repositories
{
    public interface IUserRepository : IBaseRepository<User> 
    {
            
    }
    
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
