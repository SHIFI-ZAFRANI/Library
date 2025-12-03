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
        public List<User> GetUsers();
        public User GetUserById(int id);
        public User PostUser(User user);
        public void PutUser(User user);
        public void DeleteUser(int id);
    }
}
