using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.Helper
{
    public static class ProgressSmooth
    {
        /// <summary>
        /// ProgressBar/CyberProgressBar gibi Value özelliği olan kontrolleri hedef değere
        /// yumuşak (easing) animasyonla taşır.
        /// </summary>
        /// <param name="getValue">Mevcut değeri döndüren getter (örn: () => bar.Value)</param>
        /// <param name="setValue">Değeri set eden setter (örn: v => bar.Value = v)</param>
        /// <param name="min">Minimum değer (örn: bar.Minimum)</param>
        /// <param name="max">Maksimum değer (örn: bar.Maximum)</param>
        /// <param name="to">Hedef değer</param>
        /// <param name="durationMs">Animasyon süresi (ms)</param>
        /// <param name="fps">Kare/saniye (ne kadar yüksek, o kadar akıcı)</param>
        public static async Task ToAsync(
            Func<int> getValue,
            Action<int> setValue,
            int min,
            int max,
            int to,
            int durationMs = 600,
            int fps = 60,
            CancellationToken ct = default)
        {
            to = Math.Max(min, Math.Min(max, to));
            int from = getValue();
            if (from == to || durationMs <= 0)
            {
                setValue(to);
                return;
            }

            // Easing: EaseOutCubic (yumuşak başlayan, sonda yavaşlayan)
            double Ease(double t) => 1 - Math.Pow(1 - t, 3);

            var sw = Stopwatch.StartNew();
            int frameDelay = Math.Max(1, 1000 / fps);

            while (sw.ElapsedMilliseconds < durationMs)
            {
                if (ct.IsCancellationRequested) break;

                double t = sw.ElapsedMilliseconds / (double)durationMs;
                double eased = Ease(t);
                int val = (int)Math.Round(from + (to - from) * eased);
                val = Math.Max(min, Math.Min(max, val));
                setValue(val);

                await Task.Delay(frameDelay);
            }

            // Hedefe kilitle
            setValue(to);
        }

        /// <summary>
        /// Standart WinForms ProgressBar için kolay kullanım (UI thread safe).
        /// </summary>
        public static Task ToAsync(ProgressBar bar, int to, int durationMs = 600, int fps = 60, CancellationToken ct = default)
        {
            if (bar.InvokeRequired)
                return (Task)bar.Invoke(new Func<Task>(() => ToAsync(() => bar.Value, v => bar.Value = v, bar.Minimum, bar.Maximum, to, durationMs, fps, ct)));

            return ToAsync(() => bar.Value, v => bar.Value = v, bar.Minimum, bar.Maximum, to, durationMs, fps, ct);
        }

        /// <summary>
        /// CyberProgressBar gibi Value/min/max olan custom kontroller için örnek overload.
        /// </summary>
        public static Task ToAsync(dynamic customBar, int to, int durationMs = 600, int fps = 60, CancellationToken ct = default)
        {
            // dynamic ile Value/Minimum/Maximum property’leri olan her bar’ı destekler.
            if (customBar is Control c && c.InvokeRequired)
                return (Task)c.Invoke(new Func<Task>(() => ToAsync(() => (int)customBar.Value, v => customBar.Value = v, (int)customBar.Minimum, (int)customBar.Maximum, to, durationMs, fps, ct)));

            return ToAsync(() => (int)customBar.Value, v => customBar.Value = v, (int)customBar.Minimum, (int)customBar.Maximum, to, durationMs, fps, ct);
        }
    }
}