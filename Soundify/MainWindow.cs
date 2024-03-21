namespace Soundify
{
    public partial class MainWindow : Form
    {
        //Dark window title by Jonas Kohl - https://jonaskohl.de/ | https://github.com/jonaskohl
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (IsWindows10OrGreater(17763))
            {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985))
                {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        private static bool IsWindows10OrGreater(int build = -1)
        {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }

        public MainWindow() { InitializeComponent(); }

        private void MainWindow_Load(object sender, EventArgs e) { Setup(); }

        //Default 1000, 700 (300)
        //600, 300
        //900, 558
        private void Setup()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;
            Text = Info.Name;
            SizeGripStyle = SizeGripStyle.Show;
            Size = new(1000, 700);
            BackColor = Color.FromArgb(32, 32, 32);
            UseImmersiveDarkMode(Handle, true);
            TopMost = false;
            MinimumSize = new(900, 558);
            MaximumSize = new(int.MaxValue, int.MaxValue);

            RTBConsole.Multiline = true;
            RTBConsole.ReadOnly = true;
            RTBConsole.ScrollBars = RichTextBoxScrollBars.ForcedVertical;

            MainFormTimer.Enabled = true;
            MainFormTimer.Interval = 1100;
            AppUpdateCheck.Enabled = true;
            AppUpdateCheck.Interval = 19900;

            DRPC.Init();
            MediaController.Init();
            FormConsole.RTB = RTBConsole;
            Themer.TP = FormTabPages;

            SoundCloudWView.Source = new("https://soundcloud.com/discover");
            SpotifyWView.Source = new("https://open.spotify.com/");
            VisualizerWebView.Source = new($"file://{Directory.GetCurrentDirectory()}\\SoundifyVisuals\\index.html");

            VersionLabel.Text = Info.AppVersion;

            UpdateChecker.Check();
            Configs.Setup();
            Configs.Load();

            FormConsole.Log("Application loaded!");

            //For now
            Text = Info.Name + " [BETA] [TESTING PHASE]";
            Animthrd.Start();
        }

        //Main timer for everything
        private static readonly string[] AnimBar =
        [
            "",
            "<>",
            "<=>",
            "<==>",
            "<===>",
            "<====>",
            "<=====>",
            "<======>",
            "<=====>",
            "<====>",
            "<===>",
            "<==>",
            "<=>",
            "<>",
            ""
        ];
        private static readonly Thread Animthrd = new(new ThreadStart(OscAnimation));
#pragma warning disable IDE0044 // Add readonly modifier
        private static bool Animbool = false;
#pragma warning restore IDE0044 // Add readonly modifier
        private static void OscAnimation()
        {
            while (Animbool)
            {
                foreach (var s in AnimBar)
                {
                    OSCManager.SendChatbox($"(song)\n{s}");
                    Thread.Sleep(1100);
                }
            }
        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            DRPC.Update();

            if (Toggles.OscTog) 
            {
                OSCManager.SendMusic("Test", "Test Artist");
            }

            if (Toggles.OscSongShowTog)
            {
                OSCManager.SendChatbox("Test");
            }

            if (Toggles.OscAnimTog) 
            {
                Animbool = true;
            }
            else
            {
                Animbool = false;
            }

            //if (Toggles.ShowSongRPC) { }

            if (Toggles.OscSendTime)
            {
                OSCManager.SendTime();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configs.Save();
            DRPC.End();
            MainFormTimer.Dispose();
            AppUpdateCheck.Dispose();
            SaveLogs.Save();
            Animthrd.Abort();
            try { MediaController.mediaManager.Dispose(); } catch { }
        }

        private void JonasCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonaskohl.de/");
        }

        private void DubyaCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/DubyaDude");
        }

        private void LacheeCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Lachee");
        }

        private void TaiizorCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Taiizor");
        }

        private void ChanyaCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ChanyaVRC");
        }

        private void ScrimPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/scrim-dev");
        }

        private void TkPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/terkoshi");
        }

        private void WebsitePicBoxBtn_Click(object sender, EventArgs e)
        {
            Process.Start(Info.MainSiteUrl);
        }

        private void YTPicBoxBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC47ldRzs1HoJiib7oPew8JQ");
        }

        private void GhPicBoxBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/terkoshi");
            Process.Start("https://github.com/scrim-dev");
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {           
            try
            {
                var sesh = MediaController.mediaManager.WindowsSessionManager.GetCurrentSession();
                _ = sesh.TrySkipNextAsync();
            }
            catch { }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {           
            try
            {
                var sesh = MediaController.mediaManager.WindowsSessionManager.GetCurrentSession();
                _ = sesh.TrySkipPreviousAsync();
            }
            catch { }
        }

        private void PausePlayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var sesh = MediaController.mediaManager.WindowsSessionManager.GetCurrentSession();
                _ = sesh.TryTogglePlayPauseAsync();
            }
            catch { FormConsole.Error("Failed to play/pause. Are you even listening to music right now?"); }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {       
            try
            {
                var sesh = MediaController.mediaManager.WindowsSessionManager.GetCurrentSession();
                _ = sesh.TryStopAsync();
            }
            catch (Exception ex) { FormConsole.Error($"Failed to stop the music ({ex})"); }
        }

        private void AppUpdateCheck_Tick(object sender, EventArgs e)
        {
            UpdateChecker.Check();
        }

        //Addons stuff
        private void EnableOSCBtn_Click(object sender, EventArgs e)
        {
            Toggles.OscTog = true;
        }

        private void OscAnimBtnOn_Click(object sender, EventArgs e)
        {
            Toggles.OscAnimTog = true;
        }

        private void DisableOscBtn_Click(object sender, EventArgs e)
        {
            Toggles.OscTog = false;
        }

        private void OscAnimBtnOff_Click(object sender, EventArgs e)
        {
            Toggles.OscAnimTog = false;
        }

        private void PrintSongOnlyBtn_Click(object sender, EventArgs e)
        {
            Toggles.OscSongShowTog = true;
        }

        private void DefaultPrintBtn_Click(object sender, EventArgs e)
        {
            Toggles.OscSongShowTog = false;
        }

        private void EnableDRPCBtn_Click(object sender, EventArgs e)
        {
            try { DRPC.Init(); } catch { }
        }

        private void DisableDRPCBtn_Click(object sender, EventArgs e)
        {
            try { DRPC.End(); } catch { }
        }

        private void ShowSongBtn_Click(object sender, EventArgs e)
        {
            Toggles.ShowSongRPC = true;
        }

        private void HideSongBtn_Click(object sender, EventArgs e)
        {
            Toggles.ShowSongRPC = false;
        }

        private void ResetRPCBtn_Click(object sender, EventArgs e)
        {
            try { DRPC.End(); DRPC.Init(); DRPC.Update(); } catch { }
        }

        //Settings stuff
        private void SaveConfigBtn_Click(object sender, EventArgs e)
        {
            Configs.Save();
        }

        private void DeleteConfigBtn_Click(object sender, EventArgs e)
        {
            try { Directory.Delete(AppDirs.ConfigFolder, true); } catch { }

            if (!Directory.Exists(AppDirs.ConfigFolder))
            {
                MsgBox.Msg("Config deleted!");
            }

            try { Directory.CreateDirectory(AppDirs.ConfigFolder); } catch { }
        }

        private void OpenConfigBtn_Click(object sender, EventArgs e)
        {
            try { Process.Start(AppDirs.ConfigFolder); } catch { }
        }

        private void CheckForUpdatesBtn_Click(object sender, EventArgs e)
        {
            MsgBox.Question("This will close the app and run the Updater. Would you like to continue?", delegate
            {
                Alerts.SuccessTone();
                Thread.Sleep(1000);
                try { UpdateChecker.RunUpdater(); } 
                catch (Exception ex) { MsgBox.Error($"Failed to open updater\n\n{ex}"); }
                Application.Exit();
            }, delegate
            {
                /* bruh sound effect */
            });
        }

        private void ForceCloseAppBtn_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void RestartAppBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void DiscordPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/ZkkjHYmRGE");
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {
            MsgBox.Msg($"Current application version is {Info.AppVersion}");
        }

        private void VisualizerWebView_Click(object sender, EventArgs e)
        {
            Process.Start($"{Directory.GetCurrentDirectory()}\\SoundifyVisuals\\index.html");
        }

        private void DefThemeBtn_Click(object sender, EventArgs e)
        {
            Themer.DefColor();
        }

        private void Purp2Btn_Click(object sender, EventArgs e)
        {
            Themer.Purple2();
        }

        private void DarkerDBtn_Click(object sender, EventArgs e)
        {
            Themer.DarkerDark();
        }

        private void SpecialThemeBtn_Click(object sender, EventArgs e)
        {
            Themer.OneOfAKind();
        }
    }
}
