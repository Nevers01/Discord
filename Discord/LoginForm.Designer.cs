namespace Discord
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            UsernameLgnTxt = new ReaLTaiizor.Controls.HopeTextBox();
            PasswordLgnTxt = new ReaLTaiizor.Controls.HopeTextBox();
            RemeberMeChck = new ReaLTaiizor.Controls.HopeCheckBox();
            LoginBtn = new ReaLTaiizor.Controls.HopeButton();
            RegisterBtn = new ReaLTaiizor.Controls.HopeButton();
            ForgotPassword = new ReaLTaiizor.Controls.LinkLabelEdit();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Top;
            hopeForm1.Font = new Font("Segoe UI", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = (Image)resources.GetObject("hopeForm1.Image");
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(429, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Discord Login";
            hopeForm1.ThemeColor = Color.FromArgb(92, 173, 255);
            // 
            // UsernameLgnTxt
            // 
            UsernameLgnTxt.BackColor = Color.White;
            UsernameLgnTxt.BaseColor = Color.FromArgb(44, 55, 66);
            UsernameLgnTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            UsernameLgnTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            UsernameLgnTxt.Font = new Font("Segoe UI", 12F);
            UsernameLgnTxt.ForeColor = Color.FromArgb(48, 49, 51);
            UsernameLgnTxt.Hint = "";
            UsernameLgnTxt.Location = new Point(68, 142);
            UsernameLgnTxt.MaxLength = 32767;
            UsernameLgnTxt.Multiline = false;
            UsernameLgnTxt.Name = "UsernameLgnTxt";
            UsernameLgnTxt.PasswordChar = '\0';
            UsernameLgnTxt.ScrollBars = ScrollBars.None;
            UsernameLgnTxt.SelectedText = "";
            UsernameLgnTxt.SelectionLength = 0;
            UsernameLgnTxt.SelectionStart = 0;
            UsernameLgnTxt.Size = new Size(295, 38);
            UsernameLgnTxt.TabIndex = 1;
            UsernameLgnTxt.TabStop = false;
            UsernameLgnTxt.Text = "Kullanıcı Adı";
            UsernameLgnTxt.UseSystemPasswordChar = false;
            // 
            // PasswordLgnTxt
            // 
            PasswordLgnTxt.BackColor = Color.White;
            PasswordLgnTxt.BaseColor = Color.FromArgb(44, 55, 66);
            PasswordLgnTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            PasswordLgnTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            PasswordLgnTxt.Font = new Font("Segoe UI", 12F);
            PasswordLgnTxt.ForeColor = Color.FromArgb(48, 49, 51);
            PasswordLgnTxt.Hint = "";
            PasswordLgnTxt.Location = new Point(68, 201);
            PasswordLgnTxt.MaxLength = 32767;
            PasswordLgnTxt.Multiline = false;
            PasswordLgnTxt.Name = "PasswordLgnTxt";
            PasswordLgnTxt.PasswordChar = '\0';
            PasswordLgnTxt.ScrollBars = ScrollBars.None;
            PasswordLgnTxt.SelectedText = "";
            PasswordLgnTxt.SelectionLength = 0;
            PasswordLgnTxt.SelectionStart = 0;
            PasswordLgnTxt.Size = new Size(295, 38);
            PasswordLgnTxt.TabIndex = 2;
            PasswordLgnTxt.TabStop = false;
            PasswordLgnTxt.Text = "Şifre";
            PasswordLgnTxt.UseSystemPasswordChar = false;
            // 
            // RemeberMeChck
            // 
            RemeberMeChck.AutoSize = true;
            RemeberMeChck.CheckedColor = Color.FromArgb(64, 158, 255);
            RemeberMeChck.DisabledColor = Color.FromArgb(196, 198, 202);
            RemeberMeChck.DisabledStringColor = Color.FromArgb(186, 187, 189);
            RemeberMeChck.Enable = true;
            RemeberMeChck.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            RemeberMeChck.EnabledStringColor = Color.FromArgb(153, 153, 153);
            RemeberMeChck.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            RemeberMeChck.Font = new Font("Segoe UI", 12F);
            RemeberMeChck.ForeColor = Color.FromArgb(48, 49, 51);
            RemeberMeChck.Location = new Point(68, 259);
            RemeberMeChck.Name = "RemeberMeChck";
            RemeberMeChck.Size = new Size(115, 20);
            RemeberMeChck.TabIndex = 3;
            RemeberMeChck.Text = "Beni Hatırla";
            RemeberMeChck.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            LoginBtn.BorderColor = Color.FromArgb(220, 223, 230);
            LoginBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            LoginBtn.DangerColor = Color.FromArgb(245, 108, 108);
            LoginBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            LoginBtn.Font = new Font("Segoe UI", 12F);
            LoginBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            LoginBtn.InfoColor = Color.FromArgb(144, 147, 153);
            LoginBtn.Location = new Point(110, 298);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            LoginBtn.Size = new Size(218, 49);
            LoginBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Giriş Yap";
            LoginBtn.TextColor = Color.White;
            LoginBtn.WarningColor = Color.FromArgb(230, 162, 60);
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BorderColor = Color.FromArgb(220, 223, 230);
            RegisterBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            RegisterBtn.DangerColor = Color.FromArgb(245, 108, 108);
            RegisterBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            RegisterBtn.Font = new Font("Segoe UI", 12F);
            RegisterBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            RegisterBtn.InfoColor = Color.FromArgb(144, 147, 153);
            RegisterBtn.Location = new Point(142, 364);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            RegisterBtn.Size = new Size(153, 37);
            RegisterBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Hesabım Yok";
            RegisterBtn.TextColor = Color.White;
            RegisterBtn.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // ForgotPassword
            // 
            ForgotPassword.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            ForgotPassword.AutoSize = true;
            ForgotPassword.BackColor = Color.Transparent;
            ForgotPassword.Font = new Font("Microsoft Sans Serif", 9F);
            ForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline;
            ForgotPassword.LinkColor = Color.FromArgb(32, 34, 37);
            ForgotPassword.Location = new Point(168, 419);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(96, 15);
            ForgotPassword.TabIndex = 6;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "Şifremi Unuttum";
            ForgotPassword.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            // 
            // LoginForm
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(429, 516);
            Controls.Add(ForgotPassword);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Controls.Add(RemeberMeChck);
            Controls.Add(PasswordLgnTxt);
            Controls.Add(UsernameLgnTxt);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTextBox UsernameLgnTxt;
        private ReaLTaiizor.Controls.HopeTextBox PasswordLgnTxt;
        private ReaLTaiizor.Controls.HopeCheckBox RemeberMeChck;
        private ReaLTaiizor.Controls.HopeButton LoginBtn;
        private ReaLTaiizor.Controls.HopeButton RegisterBtn;
        private ReaLTaiizor.Controls.LinkLabelEdit ForgotPassword;
    }
}