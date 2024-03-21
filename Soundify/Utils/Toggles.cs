using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.Utils
{
    internal class Toggles
    {
        //OSC
        public static bool OscTog {  get; set; } = false;
        public static bool OscAnimTog { get; set; } = false;
        public static bool OscSongShowTog { get; set; } = false;
        public static bool OscSendTime { get; set; } = false;

        //RPC
        public static bool ShowSongRPC { get; set; } = true;
    }
}
