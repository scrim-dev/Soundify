using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoundifyUpdater.Utils
{
    internal class Updater
    {
        private static readonly string agent = 
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36 OPR/108.0.0.0";

        private static readonly WebClient WC = new WebClient();
        public static void Update()
        {
            WC.Headers.Add("User-Agent", agent);
            Program.WorkingOn = "Checking for Soundify...";
            if (File.Exists("Soundify.exe"))
            {
                try { File.Delete("Soundify.exe"); } catch { }

                try
                {
                    WC.DownloadFile("serverurl", "Soundify.exe");
                }
                catch { }
            }
            else
            {
                //If not exist do some shit
            }
        }
    }
}
