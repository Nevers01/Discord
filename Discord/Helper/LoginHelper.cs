using Services;
using MODEL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord.Helper
{
    public class LoginHelper
    {
        private readonly PasswordHashService _phs = new PasswordHashService();

        public async Task<bool> TryLoginAsync(string username, string password)
        {
            string passwordHash = _phs.ComputeHash(password);

            using var context = new ModelDbContext();
            var loginService = new LoginService(context);

            bool loginSuccess = await loginService.CheckCredentialsAsync(username, passwordHash);
            return loginSuccess;
        }
    }
}