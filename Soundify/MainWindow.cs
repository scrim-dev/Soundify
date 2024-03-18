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
            MinimumSize = new(600, 300);
            MaximumSize = new(int.MaxValue, int.MaxValue);
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            //Process.Start(""); Open website
        }
    }
}
