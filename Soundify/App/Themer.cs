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

        public static void DefColor()
        {
            TP.ActiveLineTabColor = Color.DarkSlateBlue;
            TP.ActiveTabColor = Color.SlateBlue;

            TP.ControlBackColor = Color.FromArgb(30, 30, 30);
            TP.PageColor = Color.FromArgb(26, 26, 26);

            TP.Refresh();
        }

        public static void Purple2()
        {
            TP.ActiveLineTabColor = Color.FromArgb(99, 0, 161);
            TP.ActiveTabColor = Color.FromArgb(131, 0, 212);

            TP.ControlBackColor = Color.FromArgb(30, 30, 30);
            TP.PageColor = Color.FromArgb(26, 26, 26);

            TP.Refresh();
        }

        public static void DarkerDark()
        {
            TP.ActiveLineTabColor = Color.FromArgb(50, 0, 125);
            TP.ActiveTabColor = Color.FromArgb(85, 43, 171);

            TP.ControlBackColor = Color.FromArgb(15, 15, 15);
            TP.PageColor = Color.FromArgb(0, 0, 0);

            TP.Refresh();
        }

        public static void OneOfAKind()
        {
            TP.ActiveLineTabColor = Color.FromArgb(255, 0, 43);
            TP.ActiveTabColor = Color.FromArgb(255, 0, 64);

            TP.ControlBackColor = Color.FromArgb(143, 0, 37);
            TP.PageColor = Color.FromArgb(82, 0, 21);

            TP.Refresh();
        }
    }
}
