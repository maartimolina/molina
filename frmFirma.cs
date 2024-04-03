using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolina
{
    public partial class frmFirma : Form
    {
        private Bitmap ArchivoImagen;
        public frmFirma()
        {
            InitializeComponent();
            // Inicializa el bitmap con el tamaño del PictureBox
            ArchivoImagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void frmFirma_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics objetoLoco = Graphics.FromImage(ArchivoImagen))
                {
                    objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }

                // Actualiza la imagen del PictureBox
                pictureBox1.Image = ArchivoImagen;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ArchivoImagen.Save("Firma.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          
        }
    }
    }
