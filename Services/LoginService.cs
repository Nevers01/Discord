using Services.İnterface;
using MODEL;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class LoginService : ILoginService
    {
        private readonly ModelDbContext _context;

        public LoginService(ModelDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckCredentialsAsync(string Username, string PasswordHash)
        {
            return await _context.Users.AnyAsync(u => u.Username == Username && u.PasswordHash == PasswordHash);
        }
    }
}