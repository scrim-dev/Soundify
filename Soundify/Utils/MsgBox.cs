using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.Utils
{
    internal class MsgBox
    {
        public static void Msg(string msg)
        {
            MessageBox.Show(msg, Info.Name, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static void Warn(string msg)
        {
            MessageBox.Show(msg, Info.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg)
        {
            MessageBox.Show(msg, Info.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Question(string msg, Action Yes, Action No)
        {
            DialogResult dialogResult = MessageBox.Show(msg, Info.Name, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { Yes(); } else { No(); }
        }
    }
}
