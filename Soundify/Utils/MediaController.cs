﻿using Windows.Media.Control;
using static WindowsMediaController.MediaManager;

namespace Soundify.Utils
{
    internal class MediaController
    {
        public static MediaManager mediaManager;

        public static void Init()
        {
            mediaManager = new MediaManager();

            mediaManager.OnAnySessionOpened += OnAnySessionOpened;
            mediaManager.OnAnySessionClosed += OnAnySessionClosed;
            mediaManager.OnFocusedSessionChanged += OnFocusedSessionChanged;
            mediaManager.OnAnyMediaPropertyChanged += OnAnyMediaPropertyChanged;

            mediaManager.Start();
        }

        public static void OnAnySessionOpened(MediaSession session)
        {
            if (session != null) 
            {
                FormConsole.Log($"Sessioned opened => {session.Id}");
            }
        }

        public static void OnAnySessionClosed(MediaSession session)
        {
            if (session != null)
            {
                FormConsole.Log($"Sessioned closed => {session.Id}");
                DRPC.ResetPres();
            }
        }

        public static void OnFocusedSessionChanged(MediaSession session)
        {
            string seshinfo = "[Hidden]"; //Doing this for now until I finish getting the music name and stuff lol
            if (session != null)
            {
                if (Toggles.ShowSongRPC)
                {
                    DRPC.SetPresence("Listening to Music!", seshinfo);
                }
                else
                {
                    DRPC.SetPresence("Listening to Music!", "[Hidden]");
                }
            }
        }

        public static void OnAnyMediaPropertyChanged
            (MediaSession sender, GlobalSystemMediaTransportControlsSessionMediaProperties args)
        {
            if (sender != null || args != null) 
            {
                
            }
        }
    }
}
