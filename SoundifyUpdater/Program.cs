using System;
using System.Threading;
using Pastel;

namespace SoundifyUpdater
{
    internal class Program
    {
        public static string WorkingOn { get; set; } = null;
        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(SetConsTitle));
            thread.Start();
            Utils.Console.Log("Missing Files\n");
            Utils.Console.Error("Missing Files\n");
            Utils.Console.Warning("Missing Files\n");
            Utils.Console.Success("Missing Files\n");
            Utils.Console.Info("Missing Files\n");
            
        }

        private static void SetConsTitle()
        {
            while (true)
            {
                if(string.IsNullOrEmpty(WorkingOn) || WorkingOn == "")
                {
                    Console.Title = $"Soundify Updater";
                }
                else { Console.Title = $"Soundify Updater | {WorkingOn}"; }
                Thread.Sleep(300);
            }
        }
    }
}
