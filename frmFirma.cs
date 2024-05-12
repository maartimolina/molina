using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolina
{
    public partial class frmFirma : Form
    {
        //PROFE LA FIRMA SE GUARDA EN DOCUMENTOS, EN LA CARPETA FIRMA
        private Bitmap imagenFirma; // Almacena la imagen de la firma
        private Pen lapiz; 
        public frmFirma()
        {
            InitializeComponent();
            imagenFirma = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            lapiz = new Pen(Color.Black, 2);
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
                using (Graphics objetoLoco = Graphics.FromImage(imagenFirma))
                {
                    objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }

                // Actualiza la imagen del PictureBox
                pictureBox1.Image = imagenFirma;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = ObtenerNombreFormateado(); // Genera el nombre del archivo con fecha/hora
            string rutaArchivo = Path.Combine(ObtenerCarpetaFirma(), nombreArchivo); // Combina la ruta con el nombre del archivo

            try
            {
                imagenFirma.Save(rutaArchivo, ImageFormat.Jpeg); // Guarda la imagen de la firma en formato JPEG
                MessageBox.Show("¡Firma guardada exitosamente!"); // Mensaje de éxito
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la firma: " + ex.Message); // Manejo de errores
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            imagenFirma = new Bitmap(pictureBox1.Width, pictureBox1.Height); // Crea un nuevo mapa de bits limpio
            pictureBox1.Image = imagenFirma; // Actualiza la imagen del PictureBox

        }
        private string ObtenerNombreFormateado()
        {
            return DateTime.Now.ToString("yyyy.MM.dd.HH.mm") + ".jpg"; // Formato año-mes-día-hora-minuto.jpg
        }

        private string ObtenerCarpetaFirma()
        {
            string rutaCarpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "FIRMA");

            try
            {
                if (!Directory.Exists(rutaCarpeta)) // Si la carpeta "FIRMA" no existe
                {
                    Directory.CreateDirectory(rutaCarpeta); // Crea la carpeta "FIRMA"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la carpeta 'FIRMA': " + ex.Message); // Maneja el error de creación de carpeta
                rutaCarpeta = Path.GetTempPath(); // Usa la carpeta temporal como alternativa
            }

            return rutaCarpeta;
        }
    }
    }
