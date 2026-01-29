using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IUserServices
    {

        public Task< List<User>> GetUsersAsync();
        public Task< User> GetUserByIdAsync(int id);
        public Task< User> PostUserAsync(User user);
        public Task<User> PutUserAsync(User user);
        public Task DeleteUserAsync(int id);
 
    }
}
