using SEDC.BookApp.DataAccess;
using SEDC.BookApp.DataAccess.Repositories.EntityRepositories;
using SEDC.BookApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.BookApp.Services
{
    public class UserService
    {
        private IRepository<User> _userRepository;

        public UserService()
        {
            StaticDb database = new StaticDb();
            _userRepository = new UserEntityRepository(database);
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public string GetLastUserName(int id)
        {
            return _userRepository.GetAll(id).LastOrDefault().UserName;
        }

        public List<User> GetAllUsers(int id)
        {
            return _userRepository.GetAll(id);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void DeleteUserById(int id)
        {
            _userRepository.DeleteById(id);
        }
    }
}
