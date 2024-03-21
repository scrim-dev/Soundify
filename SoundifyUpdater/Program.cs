using System;
using System.Threading;
using Pastel;
using SoundifyUpdater.Utils;

namespace SoundifyUpdater
{
    internal class Program
    {
        public static string WorkingOn { get; set; } = null;
        static void Main()
        {
            Thread thread = new(new ThreadStart(SetConsTitle));
            thread.Start();
            Updater.Update();
        }

        private static void SetConsTitle()
        {
            while (true)
            {
                if(string.IsNullOrEmpty(WorkingOn) || WorkingOn == "")
                {
                    System.Console.Title = $"Soundify Updater";
                }
                else { System.Console.Title = $"Soundify Updater | {WorkingOn}"; }
                Thread.Sleep(300);
            }
        }
    }
}
