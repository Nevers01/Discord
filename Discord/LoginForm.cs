using Discord.Helper;
using MODEL;
using Models.Entity;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameLgnTxt.Text;
            string password = PasswordLgnTxt.Text;

            var helper = new LoginHelper();
            bool loginSuccess = await helper.TryLoginAsync(username, password);

            if (loginSuccess)
            {
                MessageBox.Show("Giriş başarılı!");
                // Ana forma geç vs.
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }
    }
}