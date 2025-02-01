using Microsoft.EntityFrameworkCore;
using VoiceOfTheCity.Data;
using VoiceOfTheCity.Models;
using System.Linq.Expressions;

namespace VoiceOfTheCity.Repositories {

    public class UserRepository : IUserRepository {

        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) {

            _context = context;
        }

        public async Task<User> GetByIdAsync(int id){
            
            return await _context.Users.FirstOrDefaultAsync( u=> u.Id == id);
        } 

        public async Task<User> GetByEmailAsync(string email) {

            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByUsernameAsync(string username) {

            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<User> AuthenticateAsync(string email , string password) {

            var user = await GetByEmailAsync(email);
            if (user == null) {
                return null;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) {

                return null;
            }
            return user;
        }

        public async Task ChangePasswordAsync( int userId, string newPassword) {

            var user = await GetByIdAsync(userId);
            if (user != null) {

                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                _context.Users.Update(user);
                await SaveChangesAsync();
            }
        }

        public async Task<bool> IsEmailExistsAsync(string email) {
            
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<User>> GetAllAsync() {

            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate) {

            return await _context.Users.Where(predicate).ToListAsync();
        }
        
        public async Task AddAsync(User user) {

            await _context.Users.AddAsync(user);
        }

        public async Task UpdateAsync(User user) {

            _context.Users.Update(user);
        }

        public async Task DeleteAsync(User user){
          
            _context.Users.Remove(user);
        }

        public async Task SaveChangesAsync() {

            await _context.SaveChangesAsync();
        }
    }
}