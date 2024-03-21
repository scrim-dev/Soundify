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
        private static readonly string FileUrl = "https://software.scrim.cc/soundify/files/Soundify.exe";
        static readonly System.Net.WebClient WC = new();

        public static void Update()
        {
            WC.Headers.Add("User-Agent", agent);
            Program.WorkingOn = "Checking for Soundify...";
            Console.Warning("Checking for Soundify...");
            if (File.Exists("Soundify.exe"))
            {
                Console.Success("Found Soundify!");
                try
                {
                    Console.Warning("Deleting old file...");
                    Program.WorkingOn = "Attempting to delete old file...";
                    File.Delete("Soundify.exe");
                }
                catch(Exception ex)
                {
                    Program.WorkingOn = "ERROR";
                    Console.Error($"[Updater]: {ex}");
                    Thread.Sleep(1200);
                    Environment.Exit(0);
                }
                try
                {
                    Console.Warning("Downloading update...");
                    Program.WorkingOn = "Downloading File...";
                    WC.DownloadFile(FileUrl, "Soundify.exe");;

                    if (File.Exists("Soundify.exe"))
                    {
                        Program.WorkingOn = "File loaded!";
                        Console.Success("Installed successfully!");
                        Thread.Sleep(555);

                        try 
                        {
                            Console.Warning("Launching...");
                            Program.WorkingOn = "Launching Soundify";
                            Process.Start("Soundify.exe"); 
                            Thread.Sleep(1200);
                            Environment.Exit(0);
                        } catch { }
                    }
                }
                catch(Exception ex)
                {
                    Console.Error($"[Updater]: {ex}");
                    Thread.Sleep(1200);
                    Environment.Exit(0);
                }
            }
            else
            {
                Program.WorkingOn = "Failed!";
                Console.Success("Soundify doesn't exist?");
                Thread.Sleep(1200);
                Environment.Exit(0);
            }
        }
    }
}
