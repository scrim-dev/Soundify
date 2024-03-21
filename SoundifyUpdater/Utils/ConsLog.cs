using System;
using Pastel;
using System.Drawing;


namespace SoundifyUpdater.Utils
{
    internal class Console
    {
        static string GetTime() => DateTime.Now.ToString("hh:mm:ss");
        static readonly string app = "Updater";
        static readonly string[] symbols = ["%", "X", "!", "✓", "i"];
        public static readonly string[] colors = ["#9974d1", "#f13542", "#f39853", "#22f06d", "#297bf0"];
        public static void Log(string str)
        { 
            System.Console.Write($"[{GetTime().Pastel(colors[0])}] [{app.Pastel(colors[0])}] [{symbols[0].Pastel(colors[0])}] {str}");
        }
        public static void Error(string str)
        {  
            System.Console.Write($"[{GetTime().Pastel(colors[1])}] [{app.Pastel(colors[1])}] [{symbols[1].Pastel(colors[1])}] {str}");
        }
        public static void Warning(string str)
        {  
            System.Console.Write($"[{GetTime().Pastel(colors[2])}] [{app.Pastel(colors[2])}] [{symbols[2].Pastel(colors[2])}] {str}");
        }
        public static void Success(string str)
        { 
            System.Console.Write($"[{GetTime().Pastel(colors[3])}] [{app.Pastel(colors[3])}] [{symbols[3].Pastel(colors[3])}] {str}");
        }
        public static void Info(string str)
        { 
            System.Console.Write($"[{GetTime().Pastel(colors[4])}] [{app.Pastel(colors[4])}] [{symbols[4].Pastel(colors[4])}] {str}");
        }
    }
}
