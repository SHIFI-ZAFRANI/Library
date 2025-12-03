using library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class UserService : IUserServices
    {

        private readonly IUserRepository _userRepositor;
        public UserService(IUserRepository userRepository)
        {
            _userRepositor = userRepository;
        }
        public User GetUserById(int id)
        {
            return _userRepositor.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _userRepositor.GetUsers();
        }

        public User PostUser(User user)
        {
            return _userRepositor.PostUser(user);
        }
        public void PutUser(User user)
        {

            _userRepositor.PutUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepositor.DeleteUser(id);
        }
    }
}
