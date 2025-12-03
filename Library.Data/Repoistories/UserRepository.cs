using library.Core.Models;
using library;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repoistories
{
    public class UserRepository :IUserRepository
    {
        private readonly DataContext _userRepository;
        public UserRepository(DataContext context)
        {
            _userRepository = context;
        }
        public List<User> GetUsers()
        {
            return _userRepository.Users;
        }

        public User GetUserById(int id)
        {
            return _userRepository.Users.Find(s => s.password == id);
        }

       
    }
}
//public List<User> GetUsers();
//public User GetUserById(int id);
