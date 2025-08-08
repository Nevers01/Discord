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
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 1) İnternet
                UpdateStatus("İnternet bağlantısı kontrol ediliyor...", /*progress just text*/ 0);
                await ProgressSmooth.ToAsync(ProgressBarStatus, 20, 600); // 0 → 20 yumuşak
                var internetOk = await SystemChecker.CheckInternetAsync();
                if (!internetOk)
                {
                    MessageBox.Show("İnternet bağlantısı yok.");
                    Application.Exit();
                    return;
                }

                // 2) Veritabanı
                UpdateStatus("Veritabanı bağlantısı kontrol ediliyor...", 0);
                await ProgressSmooth.ToAsync(ProgressBarStatus, 40, 600);
                using var db = BuildDbContext();
                var dbOk = await SystemChecker.CheckDatabaseAsync(db);
                if (!dbOk)
                {
                    MessageBox.Show("Veritabanına bağlanılamadı.");
                    Application.Exit();
                    return;
                }

                // 3) Dosya
                UpdateStatus("Dosyalar kontrol ediliyor...", 0);
                await ProgressSmooth.ToAsync(ProgressBarStatus, 60, 600);
                //var (filesOk, err) = await SystemChecker.CheckFilesAsync("manifest.json", strictHash: true);

                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(5));

                // 3) Hangisi önce biterse onu al
                var completed = await Task.WhenAny(timeoutTask);

                if (completed == timeoutTask)
                {
                    //MessageBox.Show($"Dosya kontrol hatası: {err}");
                    //Application.Exit();
                }

                // Tamamlandı
                UpdateStatus("Hazırlık tamamlandı...", 0);
                await ProgressSmooth.ToAsync(ProgressBarStatus, 100, 700);
                await Task.Delay(500);

                //// Ana forma geç
                //var main = new MainForm();
                //main.Show();
                //this.Hide();
                //this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başlatma hatası: " + ex.Message);
                Application.Exit();
            }
        }

        private void UpdateStatus(string text, int progressValue)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateStatus(text, progressValue)));
                return;
            }

            LabelStatus.Text = text;

            // ProgressBar sınır dışı olmasın
            if (progressValue < ProgressBarStatus.Minimum) progressValue = ProgressBarStatus.Minimum;
            if (progressValue > ProgressBarStatus.Maximum) progressValue = ProgressBarStatus.Maximum;

            ProgressBarStatus.Value = progressValue;
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