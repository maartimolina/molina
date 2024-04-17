namespace pryMolina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Lienzo = new frmJuego();
            Lienzo.Show();
        }
    }
}