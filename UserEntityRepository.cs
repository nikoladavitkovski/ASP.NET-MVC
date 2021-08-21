using SEDC.BookApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.BookApp.DataAccess.Repositories.EntityRepositories
{
    public class UserEntityRepository : IRepository<User>
    {
        private StaticDb _context;

        public UserEntityRepository(StaticDb context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            User user = _context.users.FirstOrDefault(x => x.Id.Equals(id));

            if(user != null)
            {
                _context.users.Remove(user);
            }
        }
        public List<User> GetAll(int id)
        {
            return _context.users.ToList();
        }

        public User GetById(int id)
        {
            return _context.users.FirstOrDefault(x => x.Id.Equals(id));
        }
        public int Insert(User entity)
        {
            _context.users.Add(entity);
            return entity.Id;
        }

        public void Update(User entity)
        {
            _context.users.Add(entity);
        }
    }
}
