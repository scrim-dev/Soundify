using System;
using System.IO;
using Console = SoundifyUpdater.Utils.Console;
namespace SoundifyUpdater.Utils
{
    internal class Updater
    {
        static readonly string agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36 OPR/108.0.0.0";

        static readonly System.Net.WebClient WC = new();

        public static void Update()
        {
            WC.Headers.Add("User-Agent", agent);
            Program.WorkingOn = "Checking for Soundify...";
            if (File.Exists("Soundify.exe"))
            {
                try
                {
                    File.Delete("Soundify.exe");
                }
                catch(Exception ex)
                {
                    Console.Error($"[Updater]: {ex}");
                }
                try
                {
                    WC.DownloadFile("https://scrim.cc/software/soundify/files/soundify.exe", "Soundify.exe");
                }
                catch(Exception ex)
                {
                    Console.Error($"[Updater]: {ex}");
                }
            }
            else
            {
                //If not exist do some shit
            }
        }
    }
}
