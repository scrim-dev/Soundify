using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Controls;

namespace Soundify.App
{
    internal class Themer
    {
        public static Color Cl { get; set; } = Color.Empty;
        public static ReaLTaiizor.Controls.TabPage TP { get; set; } = null;
        public static bool Rbow { get; set; } = false;

        private static readonly Thread thrd = new(() => 
        {
            while (true)
            {
                RainbowColor();
                Thread.Sleep(1);
            }
        });

        public static void Rainbow(bool state)
        {
            if(state)
            {
                try { thrd.Start();  } catch { }
            }
            else
            {
                try { thrd.Abort(); } catch { } //dispose
            }
        }

        private static void RainbowColor()
        {
            Cl = Clr();
            if(Rbow)
            {
                TP.ActiveLineTabColor = Cl;
                TP.ActiveTabColor = Cl;
                TP.Refresh();
            }
            else
            {
                DefColor();
            }           
        }

        public static void DefColor()
        {
            Rainbow(false);
            TP.ActiveLineTabColor = Color.DarkSlateBlue;
            TP.ActiveTabColor = Color.SlateBlue;

            TP.ControlBackColor = Color.FromArgb(30, 30, 30);
            TP.PageColor = Color.FromArgb(26, 26, 26);

            TP.Refresh();
        }

        public static void Purple2()
        {
            Rainbow(false);
            TP.ActiveLineTabColor = Color.FromArgb(99, 0, 161);
            TP.ActiveTabColor = Color.FromArgb(131, 0, 212);

            TP.ControlBackColor = Color.FromArgb(30, 30, 30);
            TP.PageColor = Color.FromArgb(26, 26, 26);

            TP.Refresh();
        }

        public static void DarkerDark()
        {
            Rainbow(false);
            TP.ActiveLineTabColor = Color.FromArgb(50, 0, 125);
            TP.ActiveTabColor = Color.FromArgb(85, 43, 171);

            TP.ControlBackColor = Color.FromArgb(15, 15, 15);
            TP.PageColor = Color.FromArgb(0, 0, 0);

            TP.Refresh();
        }

        public static Color Clr()
        {
            int r = 255, g = 0, b = 0;

            if (r == 255 && g < 255 && b == 0)
            {
                g += 1;
            }
            else if (r > 0 && g == 255 && b == 0)
            {
                r -= 1;
            }
            else if (r == 0 && g == 255 && b < 255)
            {
                b += 1;
            }
            else if (r == 0 && g > 0 && b == 255)
            {
                g -= 1;
            }
            else if (r < 255 && g == 0 && b == 255)
            {
                r += 1;
            }
            else if (r == 255 && g == 0 && b > 0)
            {
                b -= 1;
            }

            Color color = Color.FromArgb(r, g, b);
            return color;
        }
    }
}
