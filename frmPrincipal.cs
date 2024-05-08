namespace pryMolina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            Form Firma = new frmFirma();
            Firma.ShowDialog();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
        
        }
    }
}