namespace pryMolina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Mandar = new frmFirma();
            Mandar.ShowDialog();
        }
    }
}