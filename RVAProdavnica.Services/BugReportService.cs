using AutoMapper;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Services
{   
    public interface IBugReportService
    {
        List<BugReportModel> GetAll();
    }

    public class BugReportService : IBugReportService
    {
        private readonly IBugReportRepository bugRepository;

        private readonly IMapper mapper;

        public BugReportService(IBugReportRepository bugRepository, IMapper mapper)
        {
            this.bugRepository = bugRepository;
            this.mapper = mapper;
        }

        public List<BugReportModel> GetAll()
        {
            var resultFromDb = bugRepository.GetAll();
            var resultModels = mapper.Map<List<BugReportModel>>(resultFromDb);
            return resultModels;
        }
    }
}
