using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.App
{
    internal class BetaTester
    {
        public static void Allow(string Passcode)
        {
            if (string.IsNullOrEmpty(Passcode)) { File.WriteAllText(Directory.GetCurrentDirectory(), "pass"); Application.Exit(); }
            if (Passcode != "testing_soundify_scrimmane_1234") { Application.Exit(); } else { }
        }
    }
}
