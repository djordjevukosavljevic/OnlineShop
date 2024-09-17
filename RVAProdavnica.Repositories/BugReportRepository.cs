using Microsoft.Extensions.Configuration;
using RVAProdavnica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Repositories
{
    public interface IBugReportRepository : IBaseRepository<BugReport> 
    { 
    
    }
    public class BugReportRepository : BaseRepository<BugReport>, IBugReportRepository
    {
        public BugReportRepository(IConfiguration configuration) : base(configuration)
        { 
            
        }
    }
}
