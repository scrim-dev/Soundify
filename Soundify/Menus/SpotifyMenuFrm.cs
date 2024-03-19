namespace Soundify.Menus
{
    public partial class SpotifyMenuFrm : Form
    {
        public SpotifyMenuFrm()
        {
            InitializeComponent();
        }

        private void SpotifyMenuFrm_Load(object sender, EventArgs e)
        {
            Size = new(808, 661);
            BackColor = Color.FromArgb(32, 32, 32);
            FormBorderStyle = FormBorderStyle.None;
            SpotifyWebView.Source = MainWindow.Sptfy;
        }

        private void SpotifyWebView_Click(object sender, EventArgs e) { }
    }
}
