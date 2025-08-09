using Discord.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();

            ProgressBarStatus.SmoothingMode = SmoothingMode.HighQuality;
            ProgressBarStatus.Minimum = 0;
            ProgressBarStatus.Maximum = 100;
            ProgressBarStatus.Value = 0;   // sadece başlangıçta
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 1) İnternet
                UpdateStatus("İnternet bağlantısı kontrol ediliyor...");
                await ProgressSmooth.ToAsync(ProgressBarStatus, 20, 600);

                var internetOk = await SystemChecker.CheckInternetAsync();
                if (!internetOk)
                {
                    MessageBox.Show("İnternet bağlantısı yok.");
                    Application.Exit();
                    return;
                }

                // 2) Veritabanı
                UpdateStatus("Veritabanı bağlantısı kontrol ediliyor...");
                await ProgressSmooth.ToAsync(ProgressBarStatus, 40, 600);

                using var db = BuildDbContext();
                var dbOk = await SystemChecker.CheckDatabaseAsync(db);
                if (!dbOk)
                {
                    MessageBox.Show("Veritabanına bağlanılamadı.");
                    Application.Exit();
                    return;
                }

                // 3) Dosyalar (5 sn timeout ile yarış)
                UpdateStatus("Dosyalar kontrol ediliyor...");
                await ProgressSmooth.ToAsync(ProgressBarStatus, 60, 600);

                //var fileCheckTask = SystemChecker.CheckFilesAsync("manifest.json", strictHash: true);
                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(5));
                var completed = await Task.WhenAny(timeoutTask);

                if (completed == timeoutTask)
                {
                    // Zaman aşımı oldu → devam et (istersen ufak log/uyarı göster)
                    // MessageBox.Show("Dosya kontrolü zaman aşımına uğradı, devam ediliyor...");
                }
                //else
                //{
                //    var (filesOk, err) = await fileCheckTask;
                //    if (!filesOk)
                //    {
                //        MessageBox.Show($"Dosya kontrol hatası: {err}");
                //        Application.Exit();
                //        return;
                //    }
                //}

                // Final
                UpdateStatus("Hazırlık tamamlandı...");
                await ProgressSmooth.ToAsync(ProgressBarStatus, 100, 700);
                await Task.Delay(300);

                var login = new LoginForm();
                login.Show();
                this.Hide();
                // this.Dispose(); // login açıldıktan sonra kapatmak istersen aç
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başlatma hatası: " + ex.Message);
                Application.Exit();
            }
        }

        private void UpdateStatus(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateStatus(text)));
                return;
            }

            LabelStatus.Text = text;
        }

        private static MODEL.ModelDbContext BuildDbContext()
        {
            var opt = new DbContextOptionsBuilder<MODEL.ModelDbContext>()
                .UseSqlServer("Server=141.98.112.152;Database=Codebucks;User Id=Nevers;Password=Nevers231_;TrustServerCertificate=True;")
                .Options;

            return new MODEL.ModelDbContext(opt);
        }
    }
}