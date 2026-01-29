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
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync()  ;
        }

        public async Task< User> GetUserByIdAsync(int id)
        {
            return await _context.Users.ToList().FirstOrDefaultAsync(s => s.password == id);
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public  User PostUser(User user) {
            _context.Users.Add(user);
            return user;

        }
        public async Task<User> PutUserAsync(User user)
        {
            var u =await GetUserByIdAsync(user.password);
            u.password = user.password;
            u.phone = user.phone;
            u.email = user.email;
            u.name = user.name;
            return u;

        }
        public async Task DeleteUserAsync(int id)
        {
            var index =await GetUserByIdAsync(id);
            _context.Users.Remove(index);
        }

    }
 
}

