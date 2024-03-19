namespace Soundify.Menus
{
    public partial class SettingsMenuFrm : Form
    {
        public SettingsMenuFrm()
        {
            InitializeComponent();
        }

        private void SettingsMenuFrm_Load(object sender, EventArgs e)
        {
            Size = new(808, 661);
            BackColor = Color.FromArgb(32, 32, 32);
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
