using Services.İnterface;
using MODEL;

namespace Services
{
    public class LoginService : ILoginService
    {

        private readonly ModelDbContext _context;
        public LoginService(ModelDbContext context)
        { 
            _context = context;
        }
        async Task<bool> ILoginService.CheckCredentialsAsync(string Username, string PasswordHash)
        {
            return await _context.Users.AnyAsync(u => u.username == Username && u.PasswordHash == PasswordHash);
        }
    }
}