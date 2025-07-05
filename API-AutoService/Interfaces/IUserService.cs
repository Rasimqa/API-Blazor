using API_Coworking.Models;
using API_Coworking.Service;

namespace API_Coworking.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<bool> CreateUserAsync(User User);
        Task<bool> UpdateUserAsync(User User);
        Task<bool> DeleteUserAsync(int id);
        Task<User> AuthenticateAsync(string email, string password);
    }
}
