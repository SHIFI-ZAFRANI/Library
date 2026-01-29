using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IUserRepository
    {
        public Task< List<User>> GetUsersAsync();
        public Task< User> GetUserByIdAsync(int id);
        public User PostUser(User user);
        public Task<User> PutUserAsync(User user);
        public Task DeleteUserAsync(int id);
        public Task SaveAsync();
    }
}
