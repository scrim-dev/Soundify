using BuildSoft.VRChat.Osc.Chatbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundify.Utils
{
    internal class OSCManager
    {
        public static void SendChatbox(string msg)
        {
            OscChatbox.SendMessage(msg, direct: true);
        }

        public static void SendMusic(string SongPlaying, string ArtistOrName)
        {
            OscChatbox.SendMessage($"[{Info.Name}]: Playing {SongPlaying} by {ArtistOrName}", direct: true);
        }

        public static void SendTime()
        {
            OscChatbox.SendMessage($"[{Info.Name}] [TIME]: {DateTime.Now:hh:mm:ss}", direct: true);
        }

        public static void SendTime24hr()
        {
            OscChatbox.SendMessage($"[{Info.Name}] [TIME]: {DateTime.Now:HH:mm:ss}", direct: true);
        }
    }
}
