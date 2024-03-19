namespace Soundify.Menus
{
    public partial class SoundcloudMenuFrm : Form
    {
        public SoundcloudMenuFrm()
        {
            InitializeComponent();
        }

        private void SoundcloudMenuFrm_Load(object sender, EventArgs e)
        {
            Size = new(808, 661);
            BackColor = Color.FromArgb(32, 32, 32);
            FormBorderStyle = FormBorderStyle.None;
            SoundCloudWebView.Source = MainWindow.Sndcld;
        }

        private void SoundCloudWebView_Click(object sender, EventArgs e) { }
    }
}
