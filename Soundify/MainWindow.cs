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

            MainFormTimer.Enabled = true;
            MainFormTimer.Interval = 1100;
            AppUpdateCheck.Enabled = true;
            AppUpdateCheck.Interval = 19900;

            DRPC.Init();
            MediaController.Init();
            Configs.Load();

            SoundCloudWView.Source = new("https://soundcloud.com/discover");
            SpotifyWView.Source = new("https://open.spotify.com/");
            VisualizerWebView.Source = new($"file://{Directory.GetCurrentDirectory()}\\SoundifyVisuals\\index.html");

            VersionLabel.Text = Info.AppVersion;

            UpdateChecker.Check();
        }

        //Main timer for everything
        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            DRPC.Update();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configs.Save();
            DRPC.End();
            MainFormTimer.Dispose();
            AppUpdateCheck.Dispose();
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
            Process.Start("https://scrim.cc/software/soundify");
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

        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {

        }

        private void PausePlayBtn_Click(object sender, EventArgs e)
        {

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void AppUpdateCheck_Tick(object sender, EventArgs e)
        {
            UpdateChecker.Check();
        }
    }
}
