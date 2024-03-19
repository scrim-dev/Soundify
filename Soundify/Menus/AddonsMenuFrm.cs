namespace Soundify.Menus
{
    public partial class AddonsMenuFrm : Form
    {
        public AddonsMenuFrm()
        {
            InitializeComponent();
        }

        private void AddonsMenuFrm_Load(object sender, EventArgs e)
        {
            Size = new(808, 661);
            BackColor = Color.FromArgb(32, 32, 32);
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
