using API_Coworking.DBContext;
using API_Coworking.Interfaces;
using API_Coworking.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Coworking.Service
{
    public class UserService : IUserService
    {
        private readonly CoworkingServiceDBContext _context;

        public UserService(CoworkingServiceDBContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<bool> CreateUserAsync(User User)
        {
            if (await _context.User.AnyAsync(c => c.Email == User.Email))
                return false;

            _context.User.Add(User);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateUserAsync(User User)
        {
            var existingUser = await _context.User.FindAsync(User.id);
            if (existingUser == null)
                return false;

            existingUser.FullName = User.FullName;
            existingUser.Email = User.Email;
            existingUser.Password = User.Password;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var User = await _context.User.FindAsync(id);
            if (User == null)
                return false;

            _context.User.Remove(User);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            var user = await _context.User.FirstOrDefaultAsync(c => c.Email == email && c.Password == password);
            return user;
        }
    }
}
