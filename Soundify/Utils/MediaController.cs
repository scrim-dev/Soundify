using Windows.Media.Control;
using static WindowsMediaController.MediaManager;

namespace Soundify.Utils
{
    internal class MediaController
    {
        public static MediaManager mediaManager;
        public static string CurrentPlayingArtist { get; set; } = null;
        public static string CurrentPlayingTitle { get; set; } = null;
        public static string ActiveTime { get; set; } = null;
        public static void Init()
        {
            mediaManager = new MediaManager();

            mediaManager.OnAnySessionOpened += OnAnySessionOpened;
            mediaManager.OnAnySessionClosed += OnAnySessionClosed;
            mediaManager.OnFocusedSessionChanged += OnFocusedSessionChanged;
            mediaManager.OnAnyPlaybackStateChanged += OnAnyPlaybackStateChanged;
            mediaManager.OnAnyMediaPropertyChanged += OnAnyMediaPropertyChanged;
            mediaManager.OnAnyTimelinePropertyChanged += OnAnyTimelinePropertyChanged;

            mediaManager.Start();
        }

        public static void MediaUpdateThread(bool state)
        {
            if (state)
            {
                Mthread.Start();
            }
            else
            {
                Mthread.Abort();
            }
        }

        private static readonly Thread Mthread = new(new ThreadStart(MUpdate));

        private static void MUpdate()
        {
            while(true)
            {
                mediaManager?.ForceUpdate();
                Thread.Sleep(1100);
            }
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
            string seshinfo = CurrentPlayingArtist + "-" + CurrentPlayingTitle;
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
                FormConsole.Log($"Playing from {sender.Id}: {args.Title} by {args.Artist}");
                CurrentPlayingArtist = args.Artist;
                CurrentPlayingTitle = args.Title;
            }
        }

        private static void OnAnyTimelinePropertyChanged(MediaSession sender, 
            GlobalSystemMediaTransportControlsSessionTimelineProperties args)
        {   
            if (sender != null || args != null)
            {
                FormConsole.Log($"{sender.Id} timeline is now {args.Position}/{args.EndTime}");
                ActiveTime = $"{args.Position}|{args.EndTime}";
            }
        }

        private static void OnAnyPlaybackStateChanged(MediaSession sender, 
            GlobalSystemMediaTransportControlsSessionPlaybackInfo args)
        {
            if (sender != null || args != null)
            {
                FormConsole.Log(args.PlaybackStatus.ToString() + " | " + args.PlaybackRate);
            }
        }

    }
}
