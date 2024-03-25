namespace Soundify.Utils
{
    internal class DRPC
    {
        private static DiscordRpcClient DClient { get; set; }
        public static string WebViewSourceLink { get; set; } = string.Empty;
        public static bool ListenAlong {  get; set; } = false;

        private static DiscordRPC.Button SdfyBtn = null;
        private static DiscordRPC.Button ListnBtn = null;

        public static void Init()
        {
            DClient = new DiscordRpcClient("1214219110423076934")
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };

            DClient.OnReady += (sender, e) =>
            {
                FormConsole.CustomLog("DRPC", $"Received Ready from user {e.User.Username}");
            };

            DClient.OnPresenceUpdate += (sender, e) =>
            {
                FormConsole.CustomLog("DRPC", $"Received Update! {e.Presence}");
            };

            DClient.Initialize();

            SetPresence("In menu", "Not blasting music right now.", "home");
        }

        public static void Update() { DClient.Invoke(); }

        public static void End() { DClient.Dispose(); }

        public static void ResetPres() { SetPresence("In menu", "Not blasting music right now.", "searching"); }

        public static void SetPresence(string Details, string State, string img)
        {
            SdfyBtn = new()
            {
                Label = "Download Soundify",
                Url = Info.MainSiteUrl
            };

            if (ListenAlong)
            {
                ListnBtn = new()
                {
                    Label = "Listen Along",
                    Url = WebViewSourceLink
                };
            }

            DClient.SetPresence(new RichPresence()
            {
                Details = Details,
                State = State,
                Assets = new Assets()
                {
                    LargeImageKey = "soundifys_logo",
                    LargeImageText = Info.Name,
                    SmallImageKey = img,
                    SmallImageText = "v" + Info.AppVersion
                },

                Timestamps = new Timestamps()
                {
                    Start = DateTime.Now,
                },

                Buttons = [SdfyBtn, ListnBtn]
            });
        }
    }
}
