using DiscordRPC.Logging;
using System.Security.Policy;
using Windows.Media.Protection.PlayReady;

namespace Soundify.Utils
{
    internal class DRPC
    {
        private static DiscordRpcClient DClient { get; set; }
        private static DiscordRPC.Button SoundifyWebsiteBtn { get; set; }
        private static DiscordRPC.Button ListenAlongBtn { get; set; }

        public static bool ListeningToMusic { get; set; } = false;

        public static void Init()
        {
            DClient = new DiscordRpcClient("1214219110423076934")
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };

            DClient.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            DClient.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            DClient.Initialize();

            SetPresence("In menu", "Not blasting music rn :(");
        }

        public static void Update() { DClient.Invoke(); }

        public static void End() { DClient.Dispose(); }

        public static void SetPresence(string Details, string State)
        {
            SetPresButtons();

            DClient.SetPresence(new RichPresence()
            {
                Details = Details,
                State = State,
                Assets = new Assets()
                {
                    LargeImageKey = "purplesy",
                    LargeImageText = Info.Name,
                    SmallImageKey = "moosicnote",
                    SmallImageText = "v" + Info.AppVersion
                },

                Buttons = [SoundifyWebsiteBtn, ListenAlongBtn]
            });
        }

        public static void SetPresButtons()
        {
            SoundifyWebsiteBtn = new()
            {
                Label = "Download Soundify",
                Url = "https://scrim.cc/software/soundify"
            };

            if(ListeningToMusic)
            {
                ListenAlongBtn = new()
                {
                    Label = "Listen Along",
                    Url = "https://placehold.co/600x400?text=Hello+World" //Will work on later
                };
            }
        }
    }
}
