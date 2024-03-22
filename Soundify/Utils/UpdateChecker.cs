namespace Soundify.Utils
{
    internal class UpdateChecker
    {
        private static WebClient Client { get; set; }
        public static void Check()
        {
            Client = new WebClient();
            Client.Headers.Add("User-Agent", Info.AppUserAgent);

            if (Info.AppVersion != GetVersionFromHost())
            {
                MsgBox.Question("Soundify has a new update or the current version your on is outdated! Would you like to update now?", delegate
                {
                    RunUpdater();
                }, delegate
                {
                    /* Fortnite */
                });
            }
            else if(string.IsNullOrEmpty(GetVersionFromHost()))
            {
                MsgBox.Error("Uhh this should not have happened. Whoops, contact Scrim");
            }
        }

        public static void RunUpdater()
        {
            try { Process.Start(Info.UpdaterName); } catch (Exception e) { MsgBox.Error($"Updater failed to run\n{e}"); }
        }

        private static string GetVersionFromHost()
        {
            try
            {
                string s = Client.DownloadString(Info.VersionFile);
                return s;
            } 
            catch
            {
                return null;
            }
        }
    }
}
