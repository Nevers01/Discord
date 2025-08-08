using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Discord.Helper
{
    public static class SystemChecker
    {
        // 1) İnternet: 2 farklı endpoint ile dener, 3 sn timeout
        public static async Task<bool> CheckInternetAsync(int timeoutMs = 3000)
        {
            using var cts = new CancellationTokenSource(timeoutMs);
            try
            {
                using var http = new HttpClient();
                http.Timeout = TimeSpan.FromMilliseconds(timeoutMs);

                // “204” dönen hafif endpoint – hızlıdır
                var resp = await http.GetAsync("http://clients3.google.com/generate_204", cts.Token);
                if (resp.IsSuccessStatusCode) return true;

                // Alternatif: Cloudflare
                resp = await http.GetAsync("https://1.1.1.1", cts.Token);
                return resp.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // 2) DB: EF Core DbContext ile bağlantı kontrolü
        public static async Task<bool> CheckDatabaseAsync(DbContext db, int timeoutSec = 3)
        {
            try
            {
                // EF Core 5+ için
                var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSec));
                return await db.Database.CanConnectAsync(tokenSource.Token);
            }
            catch
            {
                return false;
            }
        }

        // 3) Dosyalar: manifest.json ile SHA256 kontrolü (yoksa sadece Exists)
        // Manifest formatı:
        // {
        //   "files": [
        //     { "path": "Resources\\logo.png", "sha256": "AB12..." },
        //     { "path": "libs\\MyLib.dll", "sha256": "CD34..." }
        //   ]
        // }
        //public class ManifestModel
        //{
        //    public ManifestFile[] files { get; set; } = Array.Empty<ManifestFile>();
        //}

        //public class ManifestFile
        //{
        //    public string path { get; set; } = "";
        //    public string sha256 { get; set; } = ""; // opsiyonel: boşsa sadece Exists kontrol edilir
        //}

        //public static async Task<(bool ok, string? firstError)> CheckFilesAsync(
        //    string manifestPath, bool strictHash = true)
        //{
        //    if (!File.Exists(manifestPath))
        //        return (false, $"Manifest bulunamadı: {manifestPath}");

        //    ManifestModel? manifest;
        //    try
        //    {
        //        await using var fs = File.OpenRead(manifestPath);
        //        manifest = await JsonSerializer.DeserializeAsync<ManifestModel>(fs);
        //        if (manifest == null) return (false, "Manifest okunamadı.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, $"Manifest parse hatası: {ex.Message}");
        //    }

        //    foreach (var f in manifest.files)
        //    {
        //        var full = Path.GetFullPath(f.path);
        //        if (!File.Exists(full))
        //            return (false, $"Eksik dosya: {f.path}");

        //        if (!string.IsNullOrWhiteSpace(f.sha256))
        //        {
        //            var hash = ComputeSha256(full);
        //            if (!hash.Equals(f.sha256, StringComparison.OrdinalIgnoreCase))
        //            {
        //                if (strictHash)
        //                    return (false, $"Hash uyuşmuyor: {f.path}");
        //            }
        //        }
        //    }
        //    return (true, null);
        //}

        //public static string ComputeSha256(string filePath)
        //{
        //    using var sha = SHA256.Create();
        //    using var fs = File.OpenRead(filePath);
        //    var hash = sha.ComputeHash(fs);
        //    return Convert.ToHexString(hash); // .NET 5+
        //}
    }
}