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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Setup();
        }

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
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void SpotifyMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void SoundCMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddonsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void MediaControlsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void GithubPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void YoutubePicBox_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void WebsitePicBox_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void DiscordPicBox_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void FullscreenBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
