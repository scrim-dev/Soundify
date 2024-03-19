namespace Soundify.Menus
{
    public partial class MediaControlsMenuFrm : Form
    {
        public MediaControlsMenuFrm()
        {
            InitializeComponent();
        }

        private void MediaControlsMenuFrm_Load(object sender, EventArgs e)
        {
            Size = new(808, 661);
            BackColor = Color.FromArgb(32, 32, 32);
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
