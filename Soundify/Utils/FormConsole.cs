using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Services.Maps;
using static System.Net.Mime.MediaTypeNames;

namespace Soundify.Utils
{
    internal class FormConsole
    {
        public static RichTextBox RTB { get; set; } = null;
        public static bool Set24hr { get; set; } = false;

        public static void Log(string log)
        {
            RTB.SelectionStart = RTB.TextLength;
            RTB.SelectionLength = 0;

            RTB.SelectionColor = Color.Cyan;
            RTB.AppendText($"[{Time()}] [{Info.Name}] [LOG] {log}" + Environment.NewLine);
            RTB.SelectionColor = RTB.ForeColor;

            RTB.ScrollToCaret();
        }

        public static void Warn(string log)
        {
            RTB.SelectionStart = RTB.TextLength;
            RTB.SelectionLength = 0;

            RTB.SelectionColor = Color.Yellow;
            RTB.AppendText($"[{Time()}] [{Info.Name}] [WARN] {log}" + Environment.NewLine);
            RTB.SelectionColor = RTB.ForeColor;

            RTB.ScrollToCaret();
        }

        public static void Error(string log)
        {
            RTB.SelectionStart = RTB.TextLength;
            RTB.SelectionLength = 0;

            RTB.SelectionColor = Color.Red;
            RTB.AppendText($"[{Time()}] [{Info.Name}] [ERROR] {log}" + Environment.NewLine);
            RTB.SelectionColor = RTB.ForeColor;

            RTB.ScrollToCaret();

            Alerts.ErrorTone();
        }

        private static string Time()
        {
            if (Set24hr)
            {
                string Get24hr = DateTime.Now.ToString("HH:mm:ss.fff");
                return Get24hr;
            }
            else
            {
                string Get12hr = DateTime.Now.ToString("hh:mm:ss.ff");
                return Get12hr;
            }
        }
    }
}
