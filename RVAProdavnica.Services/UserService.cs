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

        UserModel GetById(int id);

        User Create(User user);

        //User Update(User user);
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

        public User Create(User user)
        {
            return mapper.Map<User>(userRepository.Create(user));
        }

        public UserModel GetById(int id)
        {
            return mapper.Map<UserModel>(userRepository.GetOne(id));
        }
        
        //public User Update(User user)
        //{
        //    mapper.Map<User>(userRepository.Update(User);
        //}
    }
}
