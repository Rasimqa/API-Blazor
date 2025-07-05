using API_BlazorForSome.Models;
using API_BlazorForSome.Service;

namespace API_BlazorForSome.Interfaces
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
