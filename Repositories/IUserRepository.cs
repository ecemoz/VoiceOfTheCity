using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Repositories {

    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUsernameAsync(string username);

        Task<User> AuthenticateAsync(string email, string password);

        Task ChangePasswordAsync(int userId, string newPassword);

        Task<bool>IsEmailExistsAsync(string email);
    }
}