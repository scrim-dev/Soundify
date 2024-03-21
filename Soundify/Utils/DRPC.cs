namespace Soundify.Utils
{
    internal class DRPC
    {
        private static DiscordRpcClient DClient { get; set; }

        public static void Init()
        {
            DClient = new DiscordRpcClient("1214219110423076934")
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };

            /*DClient.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            DClient.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            }; */

            DClient.Initialize();

            SetPresence("In menu", "Not blasting music right now.");
        }

        public static void Update() { DClient.Invoke(); }

        public static void End() { DClient.Dispose(); }

        public static void ResetPres() { SetPresence("In menu", "Not blasting music right now."); }

        public static void SetPresence(string Details, string State)
        {
            DiscordRPC.Button SoundifyWebsiteBtn = new()
            {
                Label = "Download Soundify",
                Url = Info.MainSiteUrl
            };

            DClient.SetPresence(new RichPresence()
            {
                Details = Details,
                State = State,
                Assets = new Assets()
                {
                    LargeImageKey = "soundifys_logo",
                    LargeImageText = Info.Name,
                    SmallImageKey = "searching",
                    SmallImageText = "v" + Info.AppVersion
                },

                Buttons = [SoundifyWebsiteBtn]
            });
        }
    }
}
