namespace Soundify
{
    public partial class MainWindow : Form
    {
        public static Uri Sptfy { get; set; } = null;
        public static Uri Sndcld { get; set; } = null;

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

            //Image setups
            SpotifyMenuBtn.Image = new Bitmap(Resources.spotify, new Size(30, 30));
            SoundCMenuBtn.Image = new Bitmap(Resources.soundcloud, new Size(30, 30));
            AddonsMenuBtn.Image = new Bitmap(Resources.puzzle_piece_solid, new Size(30, 30));
            MediaControlsMenuBtn.Image = new Bitmap(Resources.music_solid, new Size(30, 30));
            SettingsMenuBtn.Image = new Bitmap(Resources.gear_solid, new Size(30, 30));

            //Webview
            Sptfy = new("https://open.spotify.com/");
            Sndcld = new("https://soundcloud.com/discover");

            //MsgBox.Msg("Loaded!");
            MainFormTimer.Enabled = true;
            MainFormTimer.Interval = 1100;

            DRPC.Init();
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://scrim.cc/software/soundify");
        }

        private void SpotifyMenuBtn_Click(object sender, EventArgs e)
        {
            FormLoader(new SpotifyMenuFrm());
        }

        private void SoundCMenuBtn_Click(object sender, EventArgs e)
        {
            FormLoader(new SoundcloudMenuFrm());
        }

        private void AddonsMenuBtn_Click(object sender, EventArgs e)
        {
            FormLoader(new AddonsMenuFrm());
        }

        private void MediaControlsMenuBtn_Click(object sender, EventArgs e)
        {
            FormLoader(new MediaControlsMenuFrm());
        }

        private void SettingsMenuBtn_Click(object sender, EventArgs e)
        {
            FormLoader(new SettingsMenuFrm());
        }

        private void GithubPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/scrim-dev");
        }

        private void YoutubePicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC47ldRzs1HoJiib7oPew8JQ");
        }

        private void WebsitePicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://scrim.cc/");
        }

        private void DiscordPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ZkkjHYmRGE");
        }

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        //Load forms onto panel
        private static Form FormWindow { get; set; } = null;
        private void FormLoader(Form NewForm)
        {
            FormWindow?.Close();
            FormWindow = NewForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            NewForm.Dock = DockStyle.Fill;
            MenuHolderPanel.Controls.Add(NewForm);
            MenuHolderPanel.Tag = NewForm;
            NewForm.Visible = true;
            NewForm.BringToFront();
            NewForm.Focus();
            NewForm.Show();
        }

        //Main timer for everything :P
        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Called");
            DRPC.Update();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DRPC.End();
            //Configs.Save();
        }

        //Color 153, 116, 209
        //Hex #9974d1
        //Hover Effect
        /*private void SpotifyMenuBtn_MouseHover(object sender, EventArgs e)
        {
            SpotifyMenuBtn.BackColor = Color.FromArgb(153, 116, 209);
        }

        private void SpotifyMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            SpotifyMenuBtn.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void SoundCMenuBtn_MouseHover(object sender, EventArgs e)
        {
            SoundCMenuBtn.BackColor = Color.FromArgb(153, 116, 209);
        }

        private void SoundCMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            SoundCMenuBtn.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void AddonsMenuBtn_MouseHover(object sender, EventArgs e)
        {
            AddonsMenuBtn.BackColor = Color.FromArgb(153, 116, 209);
        }

        private void AddonsMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            AddonsMenuBtn.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void MediaControlsMenuBtn_MouseHover(object sender, EventArgs e)
        {
            MediaControlsMenuBtn.BackColor = Color.FromArgb(153, 116, 209);
        }

        private void MediaControlsMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            MediaControlsMenuBtn.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void SettingsMenuBtn_MouseHover(object sender, EventArgs e)
        {
            SettingsMenuBtn.BackColor = Color.FromArgb(153, 116, 209);
        }

        private void SettingsMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            SettingsMenuBtn.BackColor = Color.FromArgb(33, 33, 33);
        }*/
    }
}
