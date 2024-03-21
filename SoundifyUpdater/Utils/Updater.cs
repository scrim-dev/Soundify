using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Console = SoundifyUpdater.Utils.Console;
namespace SoundifyUpdater.Utils
{
    internal class Updater
    {
        static readonly string agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36 OPR/108.0.0.0";
        private static readonly string FileUrl = "url";
        static readonly System.Net.WebClient WC = new();

        public static void Update()
        {
            WC.Headers.Add("User-Agent", agent);
            Program.WorkingOn = "Checking for Soundify...";
            if (File.Exists("Soundify.exe"))
            {
                try
                {
                    Program.WorkingOn = "Attempting to delete old file...";
                    File.Delete("Soundify.exe");
                }
                catch(Exception ex)
                {
                    Program.WorkingOn = "ERROR";
                    Console.Error($"[Updater]: {ex}\n");
                }
                try
                {
                    Program.WorkingOn = "Downloading File...";
                    WC.DownloadFile(FileUrl, "Soundify.exe");;

                    if (File.Exists("Soundify.exe"))
                    {
                        Program.WorkingOn = "File loaded!";
                        Console.Success("Installed successfully!\n");
                        Thread.Sleep(555);

                        try { Process.Start("Soundify.exe"); } catch { }
                    }
                }
                catch(Exception ex)
                {
                    Console.Error($"[Updater]: {ex}\n");
                }
            }
            else
            {
                Program.WorkingOn = "???";
                Console.Success("Soundify doesn't exist?\n");
                Thread.Sleep(1000);
            }
        }
    }
}
