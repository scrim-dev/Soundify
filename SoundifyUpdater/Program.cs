using SoundifyUpdater.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoundifyUpdater
{
    internal class Program
    {
        public static string WorkingOn { get; set; } = null;
        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(SetConsTitle));
            thread.Start();
            Updater.Update();
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
