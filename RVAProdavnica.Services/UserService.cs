using AutoMapper;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Services
{
    public interface IUserService
    {
        List<UserModel> GetAll();

        UserModel GetById(int id);

        int? Create(UserModel obj);

        void Update(UserModel obj);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public List<UserModel> GetAll()
        {
            var resultsFromDb = userRepository.GetAll();
            var resultModels = mapper.Map<List<UserModel>>(resultsFromDb);
            return resultModels;
        }

        public UserModel GetById(int id)
        {
            return mapper.Map<UserModel>(userRepository.GetOne(id));
        }

        public int? Create(UserModel obj)
        {
            return userRepository.Create(mapper.Map<User>(obj));
        }

        public void Update(UserModel obj)
        {
            userRepository.Update(mapper.Map<User>(obj));
        }
    }
}
