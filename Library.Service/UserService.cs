using library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Data.Repoistories;
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
        public async Task< User> GetUserByIdAsync(int id)
        {
            return await _userRepositor.GetUserByIdAsync(id);
        }

        public Task< List<User>> GetUsersAsync()
        {
            return _userRepositor.GetUsersAsync();
        }

        public async Task< User> PostUserAsync(User user)
        {
            var u= _userRepositor.PostUser(user);
            await _userRepositor.SaveAsync();
            return u;
        }
        public async Task PutUser(User user)
        {

            await _userRepositor.PutUserAsync(user);
           await _userRepositor.SaveAsync();
        }

        public async void DeleteUser(int id)
        {
          await  _userRepositor.DeleteUserAsync(id);

           await _userRepositor.SaveAsync();
        }
    }
}
